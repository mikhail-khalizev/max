using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6730-69d22f4c")]
        public void Method_1007_6730()
        {
            ii(0x1007_6730, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_6735, 5); call(Definitions.sys_check_available_stack_size, 0xe_f618); /* call 0x10165d52 */
            ii(0x1007_673a, 1); push(ebx);                              /* push ebx */
            ii(0x1007_673b, 1); push(ecx);                              /* push ecx */
            ii(0x1007_673c, 1); push(edx);                              /* push edx */
            ii(0x1007_673d, 1); push(esi);                              /* push esi */
            ii(0x1007_673e, 1); push(edi);                              /* push edi */
            ii(0x1007_673f, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6740, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6742, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_6748, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_674b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_674e, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1007_6751, 2); if(jz(0x1007_675c, 9)) goto l_0x1007_675c; /* jz 0x1007675c */
            ii(0x1007_6753, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_675a, 2); jmp(0x1007_6775, 0x19); goto l_0x1007_6775; /* jmp 0x10076775 */
        l_0x1007_675c:
            ii(0x1007_675c, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x1007_6761, 5); mov(ebx, StringDefinitions.SmartptrH);  /* mov ebx, 0x101a002c */
            ii(0x1007_6766, 5); mov(edx, StringDefinitions.PtrNotEqual0); /* mov edx, 0x101a0037 */
            ii(0x1007_676b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_676d, 5); call(Definitions.sys_assert, 0xe_f620); /* call 0x10165d92 */
            ii(0x1007_6772, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1007_6775:
            ii(0x1007_6775, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_6778, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_677a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_677d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_6780, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6782, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6783, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6784, 1); pop(esi);                               /* pop esi */
            ii(0x1007_6785, 1); pop(edx);                               /* pop edx */
            ii(0x1007_6786, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6787, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6788, 1); ret();                                  /* ret */
        }
    }
}
