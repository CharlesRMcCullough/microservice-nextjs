import { Metadata } from "next";
import "./globals.css";
import NavBar from "./nav/NavBar";


export const metadata: Metadata = {
  title: "Create Next App",
  description: "Generated by create next app",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body>
          <NavBar />
          <main className='container mx-auto px-5 pt-10'>
          {children}
          </main>

      </body>
    </html>
  );
}
