interface IProps {
  name: {
    firstName: string,
    lastName: string
  }
}

export const Person = ({name}: IProps) => {
  return (
    <div>
      {name.firstName} {name.lastName}
    </div>
  )
}