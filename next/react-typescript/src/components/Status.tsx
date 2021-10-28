interface IStatusProps {
  status: 'loading' | 'success' | 'error'
}

export const Status = ({status} : IStatusProps) => {
  let message;
  if (status === 'loading') {
    message = 'Loading...'
  }
  return (
    <div>
      <h2>{message}</h2>
    </div>
  )
}