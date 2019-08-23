using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0648-de8095f1")]
        public void Method_100e_0648()
        {
            ii(0x100e_0648, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_064d, 5); call(Definitions.sys_check_available_stack_size, 0x8_5700); /* call 0x10165d52 */
            ii(0x100e_0652, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0653, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0654, 1); push(edx);                              /* push edx */
            ii(0x100e_0655, 1); push(esi);                              /* push esi */
            ii(0x100e_0656, 1); push(edi);                              /* push edi */
            ii(0x100e_0657, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0658, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_065a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0660, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_0663, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0666, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x100e_0669, 2); if(jz(0x100e_0674, 0x9)) goto l_0x100e_0674; /* jz 0x100e0674 */
            ii(0x100e_066b, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100e_0672, 2); jmp(0x100e_068d, 0x19); goto l_0x100e_068d; /* jmp 0x100e068d */
        l_0x100e_0674:
            ii(0x100e_0674, 5); mov(ecx, 0x112);                        /* mov ecx, 0x112 */
            ii(0x100e_0679, 5); mov(ebx, StringDefinitions.TextfileH2); /* mov ebx, 0x101a17c4 */
            ii(0x100e_067e, 5); mov(edx, StringDefinitions.PtrNotEqual016); /* mov edx, 0x101a17cf */
            ii(0x100e_0683, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_0685, 5); call(Definitions.sys_assert, 0x8_5708); /* call 0x10165d92 */
            ii(0x100e_068a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x100e_068d:
            ii(0x100e_068d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0690, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_0692, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_0695, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_0698, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_069a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_069b, 1); pop(edi);                               /* pop edi */
            ii(0x100e_069c, 1); pop(esi);                               /* pop esi */
            ii(0x100e_069d, 1); pop(edx);                               /* pop edx */
            ii(0x100e_069e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_069f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_06a0, 1); ret();                                  /* ret */
        }
    }
}
