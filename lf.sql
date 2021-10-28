select p.Id AS ProductId, br.Id,
pt.Name AS ProductName,
p.Sku,
p.Collection,
	CASE 
		WHEN p.Stock <= MinimunStockAlert THEN 'เหลือน้อย'
		WHEN p.Stock > MinimunStockAlert THEN 'ปกติ'
		WHEN p.Stock = 0 THEN 'สิ้นค้าหมด'
	END AS StockStatus,
(SELECT COALESCE(p.Stock + p.ExternalStock, p.Stock, p.ExternalStock) AS TotalStock) AS TotalStock,
p.ExternalStock AS OfflineStock,
br.Id AS BranchId,
bt.Name AS BranchName,
sc.Name AS SalesChannelName,
	CASE 
		WHEN (SELECT s.Quantity FRom Stock s WHERE s.ProductId = p.Id AND s.BranchId = br.Id) IS NOT NULL
		OR (SELECT s.Quantity FRom Stock s WHERE s.ProductId = p.Id AND s.BranchId = br.Id) <> 0
		THEN (SELECT s.Quantity FRom Stock s WHERE s.ProductId = p.Id AND s.BranchId = br.Id)
		ELSE 0
	END AS Stock 
from Product p 
JOIN ProductTranslation pt ON pt.ProductId = p.Id
JOIN Branch br ON br.BrandId = p.BrandId 
JOIN BranchTranslation bt ON bt.BranchId = br.Id 
LEFT JOIN SalesChannal sc ON sc.Id = br.SalesChannelId 
LEFT JOIN Stock s ON s.ProductId = p.Id
WHERE pt.LanguageId = 1
AND bt.LanguageId = 1
AND p.ProductTypeId IN (1,3)
AND p.BrandId = 12
AND p.Enabled = 1;