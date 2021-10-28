interface ChildrenProps {
  children: React.ReactNode
}

export const Children = ({children}: ChildrenProps) => {
  return <div>{children}</div>
}