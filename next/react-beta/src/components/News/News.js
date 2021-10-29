import {
  NewsContainer,
  NewsContent,
  NewsTitle,
  NewsCardContent,
  NewsCard,
  NewsIconContainer,
  NewsIcon1,
  NewsIcon2,
  NewsIcon3,
  NewsCardTitle,
  NewsCardText
} from './News.styles';

export const News = () => {
  return (
    <>
      <NewsContent>
        <NewsContainer>
          <NewsTitle>News</NewsTitle>
          <NewsCardContent>
            <NewsCard>
              <NewsIconContainer>
                <NewsIcon1 className="Icon" />
              </NewsIconContainer>
                <NewsCardTitle>คำขอเปลี่ยนแปลงผู้ใช้งาน</NewsCardTitle>
                <NewsCardText>
                  There are different meals every week to choose from. 
                  This gives you a variety of options to switch it up.
                </NewsCardText>
            </NewsCard>
            <NewsCard>
                <NewsIconContainer>
                    <NewsIcon2/>
                </NewsIconContainer>
                <NewsCardTitle>Seco</NewsCardTitle>
                <NewsCardText>
                    Choose your favorite recipes that you want to cook. 
                    Pick the category you love. 
                </NewsCardText>
            </NewsCard>
            <NewsCard>
                <NewsIconContainer>
                    <NewsIcon3/>
                </NewsIconContainer>
                <NewsCardTitle>Tranning Schedule</NewsCardTitle>
                <NewsCardText>
                    Order the meal you have chosen. 
                    Fresh and packed ingredients straight to your door step.
                </NewsCardText>
            </NewsCard>
          </NewsCardContent>
        </NewsContainer>
      </NewsContent>
    </>
  );
}