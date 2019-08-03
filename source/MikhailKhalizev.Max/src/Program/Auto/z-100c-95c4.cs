using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a20a317-e0de-43ed-9bd7-e99f0e86ec49")]
        public void Method_100c_95c4()
        {
            ii(0x100c_95c4, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100c_95c9, 5); calld(Definitions.sys_check_available_stack_size, 0x9c784); /* call 0x10165d52 */
            ii(0x100c_95ce, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_95cf, 1); pushd(esi);                             /* push esi */
            ii(0x100c_95d0, 1); pushd(edi);                             /* push edi */
            ii(0x100c_95d1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_95d2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_95d4, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_95da, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_95dd, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_95e0, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_95e3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_95e6, 4); cmp(memd_a32[ds, eax + 0x6], 0);        /* cmp dword [eax+0x6], 0x0 */
            ii(0x100c_95ea, 6); if(jzd(0x100c_9670, 0x80)) goto l_0x100c_9670; /* jz 0x100c9670 */
            ii(0x100c_95f0, 6); test(memw_a32[ss, ebp - 0x4], 0x1);     /* test word [ebp-0x4], 0x1 */
            ii(0x100c_95f6, 2); if(jzd(0x100c_9615, 0x1d)) goto l_0x100c_9615; /* jz 0x100c9615 */
            ii(0x100c_95f8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_95fb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_95fe, 5); calld(0x1007_5e64, -0x5379f);           /* call 0x10075e64 */
            ii(0x100c_9603, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_9605, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_9608, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100c_960b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_960e, 5); calld(0x100c_915e, -0x4b5);             /* call 0x100c915e */
            ii(0x100c_9613, 2); jmpd(0x100c_9630, 0x1b); goto l_0x100c_9630; /* jmp 0x100c9630 */
        l_0x100c_9615:
            ii(0x100c_9615, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_9618, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_961b, 5); calld(0x1007_5e64, -0x537bc);           /* call 0x10075e64 */
            ii(0x100c_9620, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_9622, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_9625, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100c_9628, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_962b, 5); calld(0x100c_9391, -0x29f);             /* call 0x100c9391 */
        l_0x100c_9630:
            ii(0x100c_9630, 6); test(memw_a32[ss, ebp - 0x4], 0x2);     /* test word [ebp-0x4], 0x2 */
            ii(0x100c_9636, 2); if(jzd(0x100c_9655, 0x1d)) goto l_0x100c_9655; /* jz 0x100c9655 */
            ii(0x100c_9638, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_963b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_963e, 5); calld(0x1007_5e64, -0x537df);           /* call 0x10075e64 */
            ii(0x100c_9643, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_9645, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_9648, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_964b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_964e, 5); calld(0x100c_915e, -0x4f5);             /* call 0x100c915e */
            ii(0x100c_9653, 2); jmpd(0x100c_9670, 0x1b); goto l_0x100c_9670; /* jmp 0x100c9670 */
        l_0x100c_9655:
            ii(0x100c_9655, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_9658, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100c_965b, 5); calld(0x1007_5e64, -0x537fc);           /* call 0x10075e64 */
            ii(0x100c_9660, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_9662, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_9665, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_9668, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_966b, 5); calld(0x100c_9391, -0x2df);             /* call 0x100c9391 */
        l_0x100c_9670:
            ii(0x100c_9670, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_9672, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_9673, 1); popd(edi);                              /* pop edi */
            ii(0x100c_9674, 1); popd(esi);                              /* pop esi */
            ii(0x100c_9675, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_9676, 1); retd(); return;                         /* ret */
        }
    }
}