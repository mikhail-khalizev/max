using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6fae-e7a6d253")]
        public void Method_1010_6fae()
        {
            ii(0x1010_6fae, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_6fb3, 5); call(Definitions.sys_check_available_stack_size, 0x5_ed9a); /* call 0x10165d52 */
            ii(0x1010_6fb8, 1); push(ebx);                              /* push ebx */
            ii(0x1010_6fb9, 1); push(ecx);                              /* push ecx */
            ii(0x1010_6fba, 1); push(edx);                              /* push edx */
            ii(0x1010_6fbb, 1); push(esi);                              /* push esi */
            ii(0x1010_6fbc, 1); push(edi);                              /* push edi */
            ii(0x1010_6fbd, 1); push(ebp);                              /* push ebp */
            ii(0x1010_6fbe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6fc0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_6fc6, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_6fc9, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_6fce, 5); mov(edx, 0x101c_4da4);                  /* mov edx, 0x101c4da4 */
            ii(0x1010_6fd3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_6fd6, 3); add(eax, 0x40);                         /* add eax, 0x40 */
            ii(0x1010_6fd9, 5); call(/* sys */ 0x1016_61c4, 0x5_f1e6);  /* call 0x101661c4 */
            ii(0x1010_6fde, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_6fe0, 2); if(jz(0x1010_6feb, 0x9)) goto l_0x1010_6feb; /* jz 0x10106feb */
            ii(0x1010_6fe2, 7); cmp(memb[ds, 0x101c_5630], 0);          /* cmp byte [0x101c5630], 0x0 */
            ii(0x1010_6fe9, 2); if(jnz(0x1010_6ff4, 0x9)) goto l_0x1010_6ff4; /* jnz 0x10106ff4 */
        l_0x1010_6feb:
            ii(0x1010_6feb, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_6ff2, 2); jmp(0x1010_7014, 0x20); goto l_0x1010_7014; /* jmp 0x10107014 */
        l_0x1010_6ff4:
            ii(0x1010_6ff4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_6ff7, 4); mov(ax, memw[ds, eax + 0x4c]);          /* mov ax, [eax+0x4c] */
            ii(0x1010_6ffb, 7); cmp(ax, memw[ds, 0x101c_40d0]);         /* cmp ax, [0x101c40d0] */
            ii(0x1010_7002, 2); if(jz(0x1010_700d, 0x9)) goto l_0x1010_700d; /* jz 0x1010700d */
            ii(0x1010_7004, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_700b, 2); jmp(0x1010_7014, 0x7); goto l_0x1010_7014; /* jmp 0x10107014 */
        l_0x1010_700d:
            ii(0x1010_700d, 7); mov(memd[ss, ebp - 0x8], 0x1);          /* mov dword [ebp-0x8], 0x1 */
        l_0x1010_7014:
            ii(0x1010_7014, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_7017, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_7019, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_701a, 1); pop(edi);                               /* pop edi */
            ii(0x1010_701b, 1); pop(esi);                               /* pop esi */
            ii(0x1010_701c, 1); pop(edx);                               /* pop edx */
            ii(0x1010_701d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_701e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_701f, 1); ret();                                  /* ret */
        }
    }
}
