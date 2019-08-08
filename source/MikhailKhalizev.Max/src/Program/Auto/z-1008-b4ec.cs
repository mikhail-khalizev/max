using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("af51b25f-7ec4-452e-a5ee-62b1c202a094")]
        public void Method_1008_b4ec()
        {
            ii(0x1008_b4ec, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_b4f1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_a85c); /* call 0x10165d52 */
            ii(0x1008_b4f6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b4f7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b4f8, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b4f9, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b4fa, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b4fb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b4fd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_b503, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b506, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b509, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b50c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_b50e, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_b511, 2); if(jzd(0x1008_b519, 0x6)) goto l_0x1008_b519; /* jz 0x1008b519 */
            ii(0x1008_b513, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_b517, 2); jmpd(0x1008_b51d, 0x4); goto l_0x1008_b51d; /* jmp 0x1008b51d */
        l_0x1008_b519:
            ii(0x1008_b519, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_b51d:
            ii(0x1008_b51d, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_b520, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1008_b523, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1008_b526, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b528, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b529, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b52a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b52b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b52c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b52d, 1); retd(); return;                         /* ret */
        }
    }
}
