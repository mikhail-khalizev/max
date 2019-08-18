using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5e8d-d442a4d")]
        public void Method_100b_5e8d()
        {
            ii(0x100b_5e8d, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_5e92, 5); calld(Definitions.sys_check_available_stack_size, 0xa_febb); /* call 0x10165d52 */
            ii(0x100b_5e97, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_5e98, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_5e99, 1); pushd(esi);                             /* push esi */
            ii(0x100b_5e9a, 1); pushd(edi);                             /* push edi */
            ii(0x100b_5e9b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_5e9c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5e9e, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_5ea4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_5ea7, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_5eaa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5ead, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100b_5eb0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_5eb3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_5eb5, 2); if(jnzd(0x100b_5ebd, 0x6)) goto l_0x100b_5ebd; /* jnz 0x100b5ebd */
            ii(0x100b_5eb7, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_5ebb, 2); jmpd(0x100b_5ec1, 0x4); goto l_0x100b_5ec1; /* jmp 0x100b5ec1 */
        l_0x100b_5ebd:
            ii(0x100b_5ebd, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100b_5ec1:
            ii(0x100b_5ec1, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_5ec4, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100b_5ec7, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100b_5eca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5ecc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_5ecd, 1); popd(edi);                              /* pop edi */
            ii(0x100b_5ece, 1); popd(esi);                              /* pop esi */
            ii(0x100b_5ecf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_5ed0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_5ed1, 1); retd(); return;                         /* ret */
        }
    }
}
