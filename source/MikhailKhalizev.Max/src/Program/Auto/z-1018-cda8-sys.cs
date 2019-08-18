using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_cda8-603720ac")]
        public void /* sys */ Method_1018_cda8()
        {
            ii(0x1018_cda8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_cda9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_cdab, 3); add(esp, -0x4 /* 0xfc */);              /* add esp, 0xfffffffc */
            ii(0x1018_cdae, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_cdaf, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_cdb1, 2); mov(cl, bl);                            /* mov cl, bl */
            ii(0x1018_cdb3, 2); or(bh, bh);                             /* or bh, bh */
            ii(0x1018_cdb5, 2); if(jnzd(0x1018_cdc3, 0xc)) goto l_0x1018_cdc3; /* jnz 0x1018cdc3 */
            ii(0x1018_cdb7, 1); pushd(edx);                             /* push edx */
            ii(0x1018_cdb8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_cdb9, 5); calld(/* sys */ 0x1018_c980, -0x43e);   /* call 0x1018c980 */
            ii(0x1018_cdbe, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1018_cdc1, 2); jmpd(0x1018_cddf, 0x1c); goto l_0x1018_cddf; /* jmp 0x1018cddf */
        l_0x1018_cdc3:
            ii(0x1018_cdc3, 3); cmp(bh, 0x1);                           /* cmp bh, 0x1 */
            ii(0x1018_cdc6, 2); if(jnzd(0x1018_cdda, 0x12)) goto l_0x1018_cdda; /* jnz 0x1018cdda */
            ii(0x1018_cdc8, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1018_cdcb, 1); pushd(eax);                             /* push eax */
            ii(0x1018_cdcc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_cdcd, 5); calld(/* sys */ 0x1018_ca00, -0x3d2);   /* call 0x1018ca00 */
            ii(0x1018_cdd2, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1018_cdd5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1018_cdd8, 2); jmpd(0x1018_cddf, 0x5); goto l_0x1018_cddf; /* jmp 0x1018cddf */
        l_0x1018_cdda:
            ii(0x1018_cdda, 5); mov(eax, 0);                            /* mov eax, 0x0 */
        l_0x1018_cddf:
            ii(0x1018_cddf, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1018_cde1, 2); if(jzd(0x1018_cdea, 0x7)) goto l_0x1018_cdea; /* jz 0x1018cdea */
            ii(0x1018_cde3, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1018_cde8, 2); jmpd(0x1018_cdef, 0x5); goto l_0x1018_cdef; /* jmp 0x1018cdef */
        l_0x1018_cdea:
            ii(0x1018_cdea, 5); mov(eax, 0x14f);                        /* mov eax, 0x14f */
        l_0x1018_cdef:
            ii(0x1018_cdef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_cdf0, 1); leaved();                               /* leave */
            ii(0x1018_cdf1, 1); retd(); return;                         /* ret */
        }
    }
}
