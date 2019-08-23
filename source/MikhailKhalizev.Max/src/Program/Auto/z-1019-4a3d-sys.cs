using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4a3d-1088ab17")]
        public void /* sys */ Method_1019_4a3d()
        {
            ii(0x1019_4a3d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4a3e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4a40, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4a41, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4a42, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4a43, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_4a44, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4a46, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4a48, 1); pushd(es);                              /* push es */
            ii(0x1019_4a49, 7); cmp(memd_a32[ds, 0x101c_1a54], 0);      /* cmp dword [0x101c1a54], 0x0 */
            ii(0x1019_4a50, 2); if(jzd(0x1019_4a78, 0x26)) goto l_0x1019_4a78; /* jz 0x10194a78 */
            ii(0x1019_4a52, 1); nop();                                  /* nop */
            ii(0x1019_4a53, 1); nop();                                  /* nop */
            ii(0x1019_4a54, 1); nop();                                  /* nop */
            ii(0x1019_4a55, 1); nop();                                  /* nop */
            ii(0x1019_4a56, 4); mov(dx, 0x21);                          /* mov dx, 0x21 */
            ii(0x1019_4a5a, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4a5b, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x1019_4a5d, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4a5e, 4); mov(dx, 0x43);                          /* mov dx, 0x43 */
            ii(0x1019_4a62, 2); mov(al, 0x36);                          /* mov al, 0x36 */
            ii(0x1019_4a64, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4a65, 4); mov(dx, 0x40);                          /* mov dx, 0x40 */
            ii(0x1019_4a69, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1019_4a6c, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4a6d, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1019_4a6f, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4a70, 4); mov(dx, 0x21);                          /* mov dx, 0x21 */
            ii(0x1019_4a74, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4a75, 2); and(al, 0xfe);                          /* and al, 0xfe */
            ii(0x1019_4a77, 1); outb(dx, al);                           /* out dx, al */
        l_0x1019_4a78:
            ii(0x1019_4a78, 1); popd(es);                               /* pop es */
            ii(0x1019_4a79, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4a7b, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4a7d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_4a7e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4a7f, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4a80, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4a81, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_4a82, 1); retd();                                 /* ret */
        }
    }
}
