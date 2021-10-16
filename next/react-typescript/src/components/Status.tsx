interface IStatusProps {
  status: string
}

export const Status = ({status} : IStatusProps) => {
  let message;
  if (status === 'loading') {
    message = 'Loading...'
  }
  return (
    <div>
      <h2>{message}</h2>
      <h2>Data fetched successfully</h2>
      <h2>Error fetching Data</h2>
    </div>
  )
}