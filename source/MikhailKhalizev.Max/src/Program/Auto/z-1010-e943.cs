using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e943-106f2e9b")]
        public void Method_1010_e943()
        {
            ii(0x1010_e943, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_e948, 5); call(Definitions.sys_check_available_stack_size, 0x5_7405); /* call 0x10165d52 */
            ii(0x1010_e94d, 1); push(ebx);                              /* push ebx */
            ii(0x1010_e94e, 1); push(ecx);                              /* push ecx */
            ii(0x1010_e94f, 1); push(edx);                              /* push edx */
            ii(0x1010_e950, 1); push(esi);                              /* push esi */
            ii(0x1010_e951, 1); push(edi);                              /* push edi */
            ii(0x1010_e952, 1); push(ebp);                              /* push ebp */
            ii(0x1010_e953, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e955, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_e95b, 7); cmp(memd[ds, 0x101c_4df0], 0);          /* cmp dword [0x101c4df0], 0x0 */
            ii(0x1010_e962, 2); if(jz(0x1010_e98d, 0x29)) goto l_0x1010_e98d; /* jz 0x1010e98d */
            ii(0x1010_e964, 5); mov(eax, memd[ds, 0x101c_4df0]);        /* mov eax, [0x101c4df0] */
            ii(0x1010_e969, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_e96c, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1010_e970, 2); if(jz(0x1010_e986, 0x14)) goto l_0x1010_e986; /* jz 0x1010e986 */
            ii(0x1010_e972, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_e974, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_e977, 5); call(Definitions.my_dtor_d2, -0x4_0444); /* call 0x100ce538 */
            ii(0x1010_e97c, 5); call(Definitions.sys_delete, 0x5_75e3); /* call 0x10165f64 */
            ii(0x1010_e981, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_e984, 2); jmp(0x1010_e98d, 0x7); goto l_0x1010_e98d; /* jmp 0x1010e98d */
        l_0x1010_e986:
            ii(0x1010_e986, 7); mov(memd[ss, ebp - 0x4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1010_e98d:
            ii(0x1010_e98d, 10); mov(memd[ds, 0x101c_4df0], 0);         /* mov dword [0x101c4df0], 0x0 */
            ii(0x1010_e997, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e999, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_e99a, 1); pop(edi);                               /* pop edi */
            ii(0x1010_e99b, 1); pop(esi);                               /* pop esi */
            ii(0x1010_e99c, 1); pop(edx);                               /* pop edx */
            ii(0x1010_e99d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_e99e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_e99f, 1); ret();                                  /* ret */
        }
    }
}
