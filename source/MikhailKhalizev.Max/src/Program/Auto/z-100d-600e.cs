using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_600e-b02c6dc0")]
        public void Method_100d_600e()
        {
            ii(0x100d_600e, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_6013, 5); call(Definitions.sys_check_available_stack_size, 0x8_fd3a); /* call 0x10165d52 */
            ii(0x100d_6018, 1); push(ebx);                              /* push ebx */
            ii(0x100d_6019, 1); push(ecx);                              /* push ecx */
            ii(0x100d_601a, 1); push(edx);                              /* push edx */
            ii(0x100d_601b, 1); push(esi);                              /* push esi */
            ii(0x100d_601c, 1); push(edi);                              /* push edi */
            ii(0x100d_601d, 1); push(ebp);                              /* push ebp */
            ii(0x100d_601e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6020, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_6026, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_6029, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_602c, 4); mov(memb[ds, eax + 0x31], 0);           /* mov byte [eax+0x31], 0x0 */
        l_0x100d_6030:
            ii(0x100d_6030, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_6033, 4); cmp(memb[ds, eax + 0x31], 0);           /* cmp byte [eax+0x31], 0x0 */
            ii(0x100d_6037, 2); if(jnz(0x100d_6071, 0x38)) goto l_0x100d_6071; /* jnz 0x100d6071 */
            ii(0x100d_6039, 5); call(/* sys */ 0x1016_b208, 0x9_51ca);  /* call 0x1016b208 */
            ii(0x100d_603e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100d_6041, 7); cmp(memb[ds, 0x101c_37d2], 0);          /* cmp byte [0x101c37d2], 0x0 */
            ii(0x100d_6048, 2); if(jz(0x100d_6051, 7)) goto l_0x100d_6051; /* jz 0x100d6051 */
            ii(0x100d_604a, 7); mov(memd[ss, ebp - 8], 0x1b);           /* mov dword [ebp-0x8], 0x1b */
        l_0x100d_6051:
            ii(0x100d_6051, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100d_6054, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_6057, 5); call(0x100d_5e01, -0x25b);              /* call 0x100d5e01 */
            ii(0x100d_605c, 5); call(0x100d_5094, -0xfcd);              /* call 0x100d5094 */
            ii(0x100d_6061, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_6063, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_6065, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100d_606a, 5); call(0x1010_0e32, 0x2_adc3);            /* call 0x10100e32 */
            ii(0x100d_606f, 2); jmp(0x100d_6030, -0x41); goto l_0x100d_6030; /* jmp 0x100d6030 */
        l_0x100d_6071:
            ii(0x100d_6071, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6073, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_6074, 1); pop(edi);                               /* pop edi */
            ii(0x100d_6075, 1); pop(esi);                               /* pop esi */
            ii(0x100d_6076, 1); pop(edx);                               /* pop edx */
            ii(0x100d_6077, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_6078, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_6079, 1); ret();                                  /* ret */
        }
    }
}
