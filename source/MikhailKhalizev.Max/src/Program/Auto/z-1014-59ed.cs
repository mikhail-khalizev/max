using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("84f71aac-cc23-4dc6-96a5-237f55fdc876")]
        public void Method_1014_59ed()
        {
            ii(0x1014_59ed, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1014_59f2, 5); calld(Definitions.sys_check_available_stack_size, 0x2_035b); /* call 0x10165d52 */
            ii(0x1014_59f7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_59f8, 1); pushd(esi);                             /* push esi */
            ii(0x1014_59f9, 1); pushd(edi);                             /* push edi */
            ii(0x1014_59fa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_59fb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_59fd, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_5a03, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_5a06, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_5a09, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_5a0c, 5); mov(eax, 0x14);                         /* mov eax, 0x14 */
            ii(0x1014_5a11, 5); calld(Definitions.sys_new, 0x2_03ea);   /* call 0x10165e00 */
            ii(0x1014_5a16, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_5a19, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_5a1c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_5a1f, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1014_5a23, 2); if(jzd(0x1014_5a3f, 0x1a)) goto l_0x1014_5a3f; /* jz 0x10145a3f */
            ii(0x1014_5a25, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_5a29, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_5a2c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_5a2f, 5); calld(0x1014_5632, -0x402);             /* call 0x10145632 */
            ii(0x1014_5a34, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_5a37, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_5a3a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_5a3d, 2); jmpd(0x1014_5a45, 0x6); goto l_0x1014_5a45; /* jmp 0x10145a45 */
        l_0x1014_5a3f:
            ii(0x1014_5a3f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_5a42, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1014_5a45:
            ii(0x1014_5a45, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_5a48, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_5a4b, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1014_5a4e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_5a51, 5); calld(0x1014_5766, -0x2f0);             /* call 0x10145766 */
            ii(0x1014_5a56, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1014_5a59, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_5a5c, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_5a5f, 5); calld(0x1014_585e, -0x206);             /* call 0x1014585e */
            ii(0x1014_5a64, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5a66, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5a67, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5a68, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5a69, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5a6a, 1); retd(); return;                         /* ret */
        }
    }
}
