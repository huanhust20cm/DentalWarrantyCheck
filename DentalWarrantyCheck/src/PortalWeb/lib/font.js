import { Lexend } from 'next/font/google'

export const poppins = Lexend({
    weight: [ '300','400', '500', '600', '700', '800', '900'],
    subsets: ['latin'],
    variable: "--poppins",
    display: 'swap',
})
