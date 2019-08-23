using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4b9d-be816ba0")]
        public void /* sys */ Method_1019_4b9d()
        {
            ii(0x1019_4b9d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4b9e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4ba0, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4ba1, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4ba2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4ba3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_4ba4, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4ba6, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4ba8, 1); pushd(es);                              /* push es */
            ii(0x1019_4ba9, 7); cmp(memd_a32[ds, 0x101c_1a54], 0);      /* cmp dword [0x101c1a54], 0x0 */
            ii(0x1019_4bb0, 2); if(jzd(0x1019_4c0e, 0x5c)) goto l_0x1019_4c0e; /* jz 0x10194c0e */
            ii(0x1019_4bb2, 1); nop();                                  /* nop */
            ii(0x1019_4bb3, 1); nop();                                  /* nop */
            ii(0x1019_4bb4, 1); nop();                                  /* nop */
            ii(0x1019_4bb5, 1); nop();                                  /* nop */
            ii(0x1019_4bb6, 4); mov(dx, 0x21);                          /* mov dx, 0x21 */
            ii(0x1019_4bba, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4bbb, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x1019_4bbd, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4bbe, 7); cmp(memd_a32[ds, 0x101c_1a58], 0);      /* cmp dword [0x101c1a58], 0x0 */
            ii(0x1019_4bc5, 2); if(jzd(0x1019_4be5, 0x1e)) goto l_0x1019_4be5; /* jz 0x10194be5 */
            ii(0x1019_4bc7, 1); nop();                                  /* nop */
            ii(0x1019_4bc8, 1); nop();                                  /* nop */
            ii(0x1019_4bc9, 1); nop();                                  /* nop */
            ii(0x1019_4bca, 1); nop();                                  /* nop */
            ii(0x1019_4bcb, 4); mov(ax, 0x205);                         /* mov ax, 0x205 */
            ii(0x1019_4bcf, 2); mov(bl, 0x8);                           /* mov bl, 0x8 */
            ii(0x1019_4bd1, 7); mov(cx, memw_a32[ds, 0x101c_0a30]);     /* mov cx, [0x101c0a30] */
            ii(0x1019_4bd8, 6); mov(edx, memd_a32[ds, 0x101c_0a2c]);    /* mov edx, [0x101c0a2c] */
            ii(0x1019_4bde, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4be0, 2); jmpd(0x1019_4bfc, 0x1a); goto l_0x1019_4bfc; /* jmp 0x10194bfc */
        //  ii(0x1019_4be2, 1); nop();                                  /* nop */
        //  ii(0x1019_4be3, 1); nop();                                  /* nop */
        //  ii(0x1019_4be4, 1); nop();                                  /* nop */
        l_0x1019_4be5:
            ii(0x1019_4be5, 1); pushd(ds);                              /* push ds */
            ii(0x1019_4be6, 4); mov(ax, 0x2508);                        /* mov ax, 0x2508 */
            ii(0x1019_4bea, 7); mov(cx, memw_a32[ds, 0x101c_0a30]);     /* mov cx, [0x101c0a30] */
            ii(0x1019_4bf1, 6); mov(edx, memd_a32[ds, 0x101c_0a2c]);    /* mov edx, [0x101c0a2c] */
            ii(0x1019_4bf7, 2); mov(ds, ecx);                           /* mov ds, ecx */
            ii(0x1019_4bf9, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_4bfb, 1); popd(ds);                               /* pop ds */
        l_0x1019_4bfc:
            ii(0x1019_4bfc, 4); mov(dx, 0x40);                          /* mov dx, 0x40 */
            ii(0x1019_4c00, 4); mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x1019_4c04, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4c05, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4c06, 4); mov(dx, 0x21);                          /* mov dx, 0x21 */
            ii(0x1019_4c0a, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4c0b, 2); and(al, 0xfe);                          /* and al, 0xfe */
            ii(0x1019_4c0d, 1); outb(dx, al);                           /* out dx, al */
        l_0x1019_4c0e:
            ii(0x1019_4c0e, 1); popd(es);                               /* pop es */
            ii(0x1019_4c0f, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4c11, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4c13, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_4c14, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4c15, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4c16, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4c17, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_4c18, 1); retd();                                 /* ret */
        }
    }
}
