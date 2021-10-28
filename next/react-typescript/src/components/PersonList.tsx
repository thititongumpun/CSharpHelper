interface IProps {
  personList: {
    firstName: string,
    lastName: string
  }[]
}

export const PersonList = ({personList}: IProps) => {
  return (
    <div>
      {personList.map(person => {
        return (
          <h2 key={person.firstName}>
            {person.firstName} {person.lastName}
          </h2>
        )
      })}
    </div>
  )
}