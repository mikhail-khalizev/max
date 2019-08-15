using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ea19d7ea-eb78-46ee-9f30-d8b266c90323")]
        public void Method_1011_0e0e()
        {
            ii(0x1011_0e0e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_0e13, 5); calld(Definitions.sys_check_available_stack_size, 0x5_4f3a); /* call 0x10165d52 */
            ii(0x1011_0e18, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_0e19, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_0e1a, 1); pushd(edx);                             /* push edx */
            ii(0x1011_0e1b, 1); pushd(esi);                             /* push esi */
            ii(0x1011_0e1c, 1); pushd(edi);                             /* push edi */
            ii(0x1011_0e1d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_0e1e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_0e20, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_0e26, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_0e29, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0e2c, 6); mov(al, memb_a32[ds, eax + 0x141]);     /* mov al, [eax+0x141] */
            ii(0x1011_0e32, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_0e37, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_0e39, 2); if(jzd(0x1011_0e47, 0xc)) goto l_0x1011_0e47; /* jz 0x10110e47 */
            ii(0x1011_0e3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0e3e, 7); mov(memd_a32[ds, eax + 0x4], 0x1);      /* mov dword [eax+0x4], 0x1 */
            ii(0x1011_0e45, 2); jmpd(0x1011_0e51, 0xa); goto l_0x1011_0e51; /* jmp 0x10110e51 */
        l_0x1011_0e47:
            ii(0x1011_0e47, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_0e4a, 7); mov(memd_a32[ds, eax + 0x8], 0x1);      /* mov dword [eax+0x8], 0x1 */
        l_0x1011_0e51:
            ii(0x1011_0e51, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_0e53, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_0e54, 1); popd(edi);                              /* pop edi */
            ii(0x1011_0e55, 1); popd(esi);                              /* pop esi */
            ii(0x1011_0e56, 1); popd(edx);                              /* pop edx */
            ii(0x1011_0e57, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_0e58, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_0e59, 1); retd(); return;                         /* ret */
        }
    }
}
