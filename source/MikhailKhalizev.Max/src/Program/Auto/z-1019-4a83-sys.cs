using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4a83-550d0c85")]
        public void /* sys */ Method_1019_4a83()
        {
            ii(0x1019_4a83, 1); push(ebp);                              /* push ebp */
            ii(0x1019_4a84, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4a86, 1); push(esi);                              /* push esi */
            ii(0x1019_4a87, 1); push(edi);                              /* push edi */
            ii(0x1019_4a88, 1); push(ebx);                              /* push ebx */
            ii(0x1019_4a89, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4a8a, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4a8c, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4a8e, 1); pushd(es);                              /* push es */
            ii(0x1019_4a8f, 3); les(edi, memd[ss, ebp + 0xc]);          /* les edi, [ebp+0xc] */
            ii(0x1019_4a92, 6); mov(memd[ds, 0x101c_0a38], edi);        /* mov [0x101c0a38], edi */
            ii(0x1019_4a98, 7); mov(memw[ds, 0x101c_0a3c], es);         /* mov [0x101c0a3c], es */
            ii(0x1019_4a9f, 7); mov(memw[ds, 0x101c_0a40], ds);         /* mov [0x101c0a40], ds */
            ii(0x1019_4aa6, 7); mov(memw[ds, 0x101c_0a46], ds);         /* mov [0x101c0a46], ds */
            ii(0x1019_4aad, 7); cmp(memd[ds, 0x101c_1a54], 0);          /* cmp dword [0x101c1a54], 0x0 */
            ii(0x1019_4ab4, 6); if(jz(0x1019_4b3a, 0x80)) goto l_0x1019_4b3a; /* jz 0x10194b3a */
            ii(0x1019_4aba, 4); mov(dx, 0x21);                          /* mov dx, 0x21 */
            ii(0x1019_4abe, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4abf, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x1019_4ac1, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4ac2, 7); cmp(memd[ds, 0x101c_1a58], 0);          /* cmp dword [0x101c1a58], 0x0 */
            ii(0x1019_4ac9, 2); if(jz(0x1019_4af9, 0x2e)) goto l_0x1019_4af9; /* jz 0x10194af9 */
            ii(0x1019_4acb, 1); nop();                                  /* nop */
            ii(0x1019_4acc, 1); nop();                                  /* nop */
            ii(0x1019_4acd, 1); nop();                                  /* nop */
            ii(0x1019_4ace, 1); nop();                                  /* nop */
            ii(0x1019_4acf, 4); mov(ax, 0x204);                         /* mov ax, 0x204 */
            ii(0x1019_4ad3, 2); mov(bl, 0x8);                           /* mov bl, 0x8 */
            ii(0x1019_4ad5, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4ad7, 6); mov(memd[ds, 0x101c_0a2c], edx);        /* mov [0x101c0a2c], edx */
            ii(0x1019_4add, 7); mov(memw[ds, 0x101c_0a30], cx);         /* mov [0x101c0a30], cx */
            ii(0x1019_4ae4, 4); mov(ax, 0x205);                         /* mov ax, 0x205 */
            ii(0x1019_4ae8, 2); mov(bl, 0x8);                           /* mov bl, 0x8 */
            ii(0x1019_4aea, 5); mov(edx, /* sys */ 0x1019_49bd);        /* mov edx, 0x101949bd */
            ii(0x1019_4aef, 3); mov(cx, cs);                            /* mov cx, cs */
            ii(0x1019_4af2, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4af4, 2); jmp(0x1019_4b20, 0x2a); goto l_0x1019_4b20; /* jmp 0x10194b20 */
        //  ii(0x1019_4af6, 1); nop();                                  /* nop */
        //  ii(0x1019_4af7, 1); nop();                                  /* nop */
        //  ii(0x1019_4af8, 1); nop();                                  /* nop */
        l_0x1019_4af9:
            ii(0x1019_4af9, 4); mov(ax, 0x3508);                        /* mov ax, 0x3508 */
            ii(0x1019_4afd, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_4aff, 6); mov(memd[ds, 0x101c_0a2c], ebx);        /* mov [0x101c0a2c], ebx */
            ii(0x1019_4b05, 7); mov(memw[ds, 0x101c_0a30], es);         /* mov [0x101c0a30], es */
            ii(0x1019_4b0c, 1); pushd(ds);                              /* push ds */
            ii(0x1019_4b0d, 3); xor(ax, ax);                            /* xor ax, ax */
            ii(0x1019_4b10, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1019_4b12, 4); mov(ax, 0x2508);                        /* mov ax, 0x2508 */
            ii(0x1019_4b16, 5); mov(edx, /* sys */ 0x1019_49bd);        /* mov edx, 0x101949bd */
            ii(0x1019_4b1b, 1); pushd(cs);                              /* push cs */
            ii(0x1019_4b1c, 1); popd(ds);                               /* pop ds */
            ii(0x1019_4b1d, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_4b1f, 1); popd(ds);                               /* pop ds */
        l_0x1019_4b20:
            ii(0x1019_4b20, 4); mov(dx, 0x43);                          /* mov dx, 0x43 */
            ii(0x1019_4b24, 2); mov(al, 0x36);                          /* mov al, 0x36 */
            ii(0x1019_4b26, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4b27, 4); mov(dx, 0x40);                          /* mov dx, 0x40 */
            ii(0x1019_4b2b, 3); mov(eax, memd[ss, ebp + 0x8]);          /* mov eax, [ebp+0x8] */
            ii(0x1019_4b2e, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4b2f, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1019_4b31, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4b32, 4); mov(dx, 0x21);                          /* mov dx, 0x21 */
            ii(0x1019_4b36, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4b37, 2); and(al, 0xfe);                          /* and al, 0xfe */
            ii(0x1019_4b39, 1); outb(dx, al);                           /* out dx, al */
        l_0x1019_4b3a:
            ii(0x1019_4b3a, 1); popd(es);                               /* pop es */
            ii(0x1019_4b3b, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4b3d, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4b3f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_4b40, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4b41, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4b42, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4b43, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_4b44, 1); ret();                                  /* ret */
        }
    }
}
