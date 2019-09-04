using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_bf54-98505e5f")]
        public void Method_100f_bf54()
        {
            ii(0x100f_bf54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bf56, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bf5b, 5); call(0x1013_ad71, 0x3_ee11);            /* call 0x1013ad71 */
            ii(0x100f_bf60, 2); test(al, al);                           /* test al, al */
            ii(0x100f_bf62, 2); if(jz(0x100f_bfa6, 0x42)) goto l_0x100f_bfa6; /* jz 0x100fbfa6 */
            ii(0x100f_bf64, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100f_bf67, 5); call(0x1007_6730, -0x8_583c);           /* call 0x10076730 */
            ii(0x100f_bf6c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_bf6e, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100f_bf71, 4); mov(memw[ds, edx + 18], ax);            /* mov [edx+0x12], ax */
            ii(0x100f_bf75, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100f_bf78, 5); call(0x1007_6730, -0x8_584d);           /* call 0x10076730 */
            ii(0x100f_bf7d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_bf7f, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100f_bf82, 4); mov(memw[ds, edx + 23], ax);            /* mov [edx+0x17], ax */
            ii(0x100f_bf86, 7); mov(memb[ds, 0x101c_388a], 0);          /* mov byte [0x101c388a], 0x0 */
            ii(0x100f_bf8d, 5); mov(al, memb[ds, 0x101c_388a]);         /* mov al, [0x101c388a] */
            ii(0x100f_bf92, 5); mov(memb[ds, 0x101c_3889], al);         /* mov [0x101c3889], al */
            ii(0x100f_bf97, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bf9c, 5); call(0x1007_6600, -0x8_59a1);           /* call 0x10076600 */
            ii(0x100f_bfa1, 5); call(0x1015_f2cc, 0x6_3326);            /* call 0x1015f2cc */
        l_0x100f_bfa6:
            ii(0x100f_bfa6, 4); cmp(memb[ss, ebp - 8], 0);              /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_bfaa, 2); if(jnz(0x100f_bfb2, 6)) goto l_0x100f_bfb2; /* jnz 0x100fbfb2 */
            ii(0x100f_bfac, 4); mov(memb[ss, ebp - 72], 1);             /* mov byte [ebp-0x48], 0x1 */
            ii(0x100f_bfb0, 2); jmp(0x100f_bfb6, 4); goto l_0x100f_bfb6; /* jmp 0x100fbfb6 */
        l_0x100f_bfb2:
            ii(0x100f_bfb2, 4); mov(memb[ss, ebp - 72], 0);             /* mov byte [ebp-0x48], 0x0 */
        l_0x100f_bfb6:
            ii(0x100f_bfb6, 3); mov(al, memb[ss, ebp - 72]);            /* mov al, [ebp-0x48] */
            ii(0x100f_bfb9, 3); mov(memb[ss, ebp - 16], al);            /* mov [ebp-0x10], al */
            ii(0x100f_bfbc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bfbe, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100f_bfc1, 5); call(0x1007_5eec, -0x8_60da);           /* call 0x10075eec */
            ii(0x100f_bfc6, 2); jmp(0x100f_bfd2, 0xa); goto l_0x100f_bfd2; /* jmp 0x100fbfd2 */
        //  ii(0x100f_bfc8, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100f_bfca, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
        //  ii(0x100f_bfcd, 5); call(0x1007_5eec, -0x8_60e6);           /* call 0x10075eec */
        l_0x100f_bfd2:
            ii(0x100f_bfd2, 3); mov(al, memb[ss, ebp - 16]);            /* mov al, [ebp-0x10] */
            ii(0x100f_bfd5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_bfd7, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_bfd8, 1); pop(edi);                               /* pop edi */
            ii(0x100f_bfd9, 1); pop(esi);                               /* pop esi */
            ii(0x100f_bfda, 1); pop(edx);                               /* pop edx */
            ii(0x100f_bfdb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_bfdc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_bfdd, 1); ret();                                  /* ret */
        }
    }
}
