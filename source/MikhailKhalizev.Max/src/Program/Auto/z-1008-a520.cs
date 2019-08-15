using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cf830dee-b2f1-44e4-bde6-2999ab3c2dca")]
        public void Method_1008_a520()
        {
            ii(0x1008_a520, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_a525, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b828); /* call 0x10165d52 */
            ii(0x1008_a52a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a52b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a52c, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a52d, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a52e, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a52f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a530, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a532, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_a538, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a53b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a53e, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1008_a541, 2); if(jzd(0x1008_a54c, 0x9)) goto l_0x1008_a54c; /* jz 0x1008a54c */
            ii(0x1008_a543, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_a54a, 2); jmpd(0x1008_a565, 0x19); goto l_0x1008_a565; /* jmp 0x1008a565 */
        l_0x1008_a54c:
            ii(0x1008_a54c, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x1008_a551, 5); mov(ebx, StringDefinitions.SmartptrH16); /* mov ebx, 0x101a00d0 */
            ii(0x1008_a556, 5); mov(edx, StringDefinitions.PtrNotEqual018); /* mov edx, 0x101a00db */
            ii(0x1008_a55b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_a55d, 5); calld(Definitions.sys_assert, 0xd_b830); /* call 0x10165d92 */
            ii(0x1008_a562, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1008_a565:
            ii(0x1008_a565, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a568, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_a56a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a56d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_a570, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a572, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a573, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a574, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a575, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a576, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a577, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a578, 1); retd(); return;                         /* ret */
        }
    }
}
