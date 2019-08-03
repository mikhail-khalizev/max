using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("926adf75-a073-4022-926a-0cf398d0dee8")]
        public void Method_1014_3616()
        {
            ii(0x1014_3616, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1014_361b, 5); calld(Definitions.sys_check_available_stack_size, 0x22732); /* call 0x10165d52 */
            ii(0x1014_3620, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_3621, 1); pushd(esi);                             /* push esi */
            ii(0x1014_3622, 1); pushd(edi);                             /* push edi */
            ii(0x1014_3623, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_3624, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_3626, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1014_362c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_362f, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_3632, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_3635, 4); or(memb_a32[ss, ebp - 0x10], 0x1);      /* or byte [ebp-0x10], 0x1 */
            ii(0x1014_3639, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_363c, 5); calld(0x1007_64fc, -0xcd145);           /* call 0x100764fc */
            ii(0x1014_3641, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_3644, 4); and(memb_a32[ss, ebp - 0x10], -0x2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1014_3648, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_364b, 5); calld(0x1007_20e6, -0xd156a);           /* call 0x100720e6 */
            ii(0x1014_3650, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_3653, 5); calld(0x1007_20e6, -0xd1572);           /* call 0x100720e6 */
            ii(0x1014_3658, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1014_365d, 5); calld(0x1007_6338, -0xcd32a);           /* call 0x10076338 */
            ii(0x1014_3662, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_3664, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3667, 5); calld(0x1007_643c, -0xcd230);           /* call 0x1007643c */
        l_0x1014_366c:
            ii(0x1014_366c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_366e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3671, 5); calld(0x1013_ad71, -0x8905);            /* call 0x1013ad71 */
            ii(0x1014_3676, 2); test(al, al);                           /* test al, al */
            ii(0x1014_3678, 2); if(jzd(0x1014_36d6, 0x5c)) goto l_0x1014_36d6; /* jz 0x101436d6 */
            ii(0x1014_367a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1014_367d, 5); calld(0x1007_20b1, -0xd15d1);           /* call 0x100720b1 */
            ii(0x1014_3682, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_3685, 5); calld(0x1007_63a0, -0xcd2ea);           /* call 0x100763a0 */
            ii(0x1014_368a, 5); calld(0x1007_6204, -0xcd48b);           /* call 0x10076204 */
            ii(0x1014_368f, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1014_3692, 2); if(jnzd(0x1014_36cc, 0x38)) goto l_0x1014_36cc; /* jnz 0x101436cc */
            ii(0x1014_3694, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1014_3697, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_369a, 5); calld(0x1007_6408, -0xcd297);           /* call 0x10076408 */
            ii(0x1014_369f, 5); calld(0x1007_21b6, -0xd14ee);           /* call 0x100721b6 */
            ii(0x1014_36a4, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1014_36a7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_36a9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_36ab, 5); calld(0x1007_213f, -0xd1571);           /* call 0x1007213f */
            ii(0x1014_36b0, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1014_36b3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_36b6, 5); calld(0x1007_6408, -0xcd2b3);           /* call 0x10076408 */
            ii(0x1014_36bb, 5); calld(0x1007_2256, -0xd146a);           /* call 0x10072256 */
            ii(0x1014_36c0, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1014_36c3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_36c5, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_36c7, 5); calld(0x1007_213f, -0xd158d);           /* call 0x1007213f */
        l_0x1014_36cc:
            ii(0x1014_36cc, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_36cf, 5); calld(0x1007_6bf8, -0xccadc);           /* call 0x10076bf8 */
            ii(0x1014_36d4, 2); jmpd(0x1014_366c, -0x6a); goto l_0x1014_366c; /* jmp 0x1014366c */
        l_0x1014_36d6:
            ii(0x1014_36d6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_36d8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1014_36db, 5); calld(0x1007_5f6c, -0xcd774);           /* call 0x10075f6c */
            ii(0x1014_36e0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_36e2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_36e3, 1); popd(edi);                              /* pop edi */
            ii(0x1014_36e4, 1); popd(esi);                              /* pop esi */
            ii(0x1014_36e5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_36e6, 1); retd(); return;                         /* ret */
        }
    }
}
