using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5c12-1a0356dd")]
        public void Method_1007_5c12()
        {
            ii(0x1007_5c12, 5); push(0x30);                             /* push 0x30 */
            ii(0x1007_5c17, 5); call(Definitions.sys_check_available_stack_size, 0xf_0136); /* call 0x10165d52 */
            ii(0x1007_5c1c, 1); push(ebx);                              /* push ebx */
            ii(0x1007_5c1d, 1); push(ecx);                              /* push ecx */
            ii(0x1007_5c1e, 1); push(edx);                              /* push edx */
            ii(0x1007_5c1f, 1); push(esi);                              /* push esi */
            ii(0x1007_5c20, 1); push(edi);                              /* push edi */
            ii(0x1007_5c21, 1); push(ebp);                              /* push ebp */
            ii(0x1007_5c22, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5c24, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_5c2a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_5c2d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_5c30, 5); call(0x1014_b77e, 0xd_5b49);            /* call 0x1014b77e */
            ii(0x1007_5c35, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_5c38, 5); call(0x1007_61d4, 0x597);               /* call 0x100761d4 */
            ii(0x1007_5c3d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_5c40, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x1007_5c44, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5c47, 5); call(0x1007_64fc, 0x8b0);               /* call 0x100764fc */
            ii(0x1007_5c4c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_5c4f, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x1007_5c53, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_5c56, 5); call(0x1007_6338, 0x6dd);               /* call 0x10076338 */
            ii(0x1007_5c5b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_5c5d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5c60, 5); call(0x1007_643c, 0x7d7);               /* call 0x1007643c */
            ii(0x1007_5c65, 2); jmp(0x1007_5c6f, 8); goto l_0x1007_5c6f; /* jmp 0x10075c6f */
        l_0x1007_5c67:
            ii(0x1007_5c67, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5c6a, 5); call(0x1007_6bf8, 0xf89);               /* call 0x10076bf8 */
        l_0x1007_5c6f:
            ii(0x1007_5c6f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5c71, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5c74, 5); call(0x1013_ad71, 0xc_50f8);            /* call 0x1013ad71 */
            ii(0x1007_5c79, 2); test(al, al);                           /* test al, al */
            ii(0x1007_5c7b, 6); if(jz(0x1007_5d22, 0xa1)) goto l_0x1007_5d22; /* jz 0x10075d22 */
            ii(0x1007_5c81, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5c84, 5); call(0x1007_63a0, 0x717);               /* call 0x100763a0 */
            ii(0x1007_5c89, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1007_5c8d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5c90, 5); call(0x1007_63a0, 0x70b);               /* call 0x100763a0 */
            ii(0x1007_5c95, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_5c97, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5c9a, 5); call(0x1007_63a0, 0x701);               /* call 0x100763a0 */
            ii(0x1007_5c9f, 4); mov(dx, memw[ds, edx + 0x1a]);          /* mov dx, [edx+0x1a] */
            ii(0x1007_5ca3, 4); mov(memw[ds, eax + 0x41], dx);          /* mov [eax+0x41], dx */
            ii(0x1007_5ca7, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5caa, 5); call(0x1007_63a0, 0x6f1);               /* call 0x100763a0 */
            ii(0x1007_5caf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_5cb1, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5cb4, 5); call(0x1007_63a0, 0x6e7);               /* call 0x100763a0 */
            ii(0x1007_5cb9, 4); mov(dx, memw[ds, edx + 0x1c]);          /* mov dx, [edx+0x1c] */
            ii(0x1007_5cbd, 4); mov(memw[ds, eax + 0x43], dx);          /* mov [eax+0x43], dx */
            ii(0x1007_5cc1, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5cc4, 5); call(0x1007_63a0, 0x6d7);               /* call 0x100763a0 */
            ii(0x1007_5cc9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_5ccb, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5cce, 5); call(0x1007_63a0, 0x6cd);               /* call 0x100763a0 */
            ii(0x1007_5cd3, 4); mov(dx, memw[ds, edx + 0x1a]);          /* mov dx, [edx+0x1a] */
            ii(0x1007_5cd7, 4); mov(memw[ds, eax + 0x1e], dx);          /* mov [eax+0x1e], dx */
            ii(0x1007_5cdb, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5cde, 5); call(0x1007_63a0, 0x6bd);               /* call 0x100763a0 */
            ii(0x1007_5ce3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_5ce5, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5ce8, 5); call(0x1007_63a0, 0x6b3);               /* call 0x100763a0 */
            ii(0x1007_5ced, 4); mov(dx, memw[ds, edx + 0x1c]);          /* mov dx, [edx+0x1c] */
            ii(0x1007_5cf1, 4); mov(memw[ds, eax + 0x20], dx);          /* mov [eax+0x20], dx */
            ii(0x1007_5cf5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5cf7, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5cfa, 5); call(0x1007_63a0, 0x6a1);               /* call 0x100763a0 */
            ii(0x1007_5cff, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1007_5d02, 5); call(0x1007_6a34, 0xd2d);               /* call 0x10076a34 */
            ii(0x1007_5d07, 7); cmp(memd[ds, 0x101c_5624], 0);          /* cmp dword [0x101c5624], 0x0 */
            ii(0x1007_5d0e, 2); if(jz(0x1007_5d1d, 0xd)) goto l_0x1007_5d1d; /* jz 0x10075d1d */
            ii(0x1007_5d10, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5d13, 5); call(0x1007_6408, 0x6f0);               /* call 0x10076408 */
            ii(0x1007_5d18, 5); call(0x1012_ae8d, 0xb_5170);            /* call 0x1012ae8d */
        l_0x1007_5d1d:
            ii(0x1007_5d1d, 5); jmp(0x1007_5c67, -0xbb); goto l_0x1007_5c67; /* jmp 0x10075c67 */
        l_0x1007_5d22:
            ii(0x1007_5d22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_5d24, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_5d27, 5); call(0x1007_5f6c, 0x240);               /* call 0x10075f6c */
            ii(0x1007_5d2c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5d2e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_5d2f, 1); pop(edi);                               /* pop edi */
            ii(0x1007_5d30, 1); pop(esi);                               /* pop esi */
            ii(0x1007_5d31, 1); pop(edx);                               /* pop edx */
            ii(0x1007_5d32, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_5d33, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_5d34, 1); ret();                                  /* ret */
        }
    }
}
