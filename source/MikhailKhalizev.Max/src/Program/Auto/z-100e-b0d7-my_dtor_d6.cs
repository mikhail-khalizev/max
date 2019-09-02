using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b0d7-4336c7bc")]
        public void my_dtor_d6()
        {
            ii(0x100e_b0d7, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100e_b0dc, 5); call(Definitions.sys_check_available_stack_size, 0x7_ac71); /* call 0x10165d52 */
            ii(0x100e_b0e1, 1); push(ebx);                              /* push ebx */
            ii(0x100e_b0e2, 1); push(ecx);                              /* push ecx */
            ii(0x100e_b0e3, 1); push(esi);                              /* push esi */
            ii(0x100e_b0e4, 1); push(edi);                              /* push edi */
            ii(0x100e_b0e5, 1); push(ebp);                              /* push ebp */
            ii(0x100e_b0e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b0e8, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_b0ee, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_b0f1, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_b0f4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_b0f7, 5); call(0x100e_b226, 0x12a);               /* call 0x100eb226 */
            ii(0x100e_b0fc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_b0ff, 3); mov(eax, memd[ds, eax + 27]);           /* mov eax, [eax+0x1b] */
            ii(0x100e_b102, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100e_b105, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100e_b109, 2); if(jz(0x100e_b11f, 0x14)) goto l_0x100e_b11f; /* jz 0x100eb11f */
            ii(0x100e_b10b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_b10d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100e_b110, 5); call(Definitions.my_dtor_d3, -0x1_33e2); /* call 0x100d7d33 */
            ii(0x100e_b115, 5); call(Definitions.sys_delete, 0x7_ae4a); /* call 0x10165f64 */
            ii(0x100e_b11a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_b11d, 2); jmp(0x100e_b126, 7); goto l_0x100e_b126; /* jmp 0x100eb126 */
        l_0x100e_b11f:
            ii(0x100e_b11f, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
        l_0x100e_b126:
            ii(0x100e_b126, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_b129, 3); mov(eax, memd[ds, eax + 35]);           /* mov eax, [eax+0x23] */
            ii(0x100e_b12c, 5); call(Definitions.sys_delete, 0x7_ae33); /* call 0x10165f64 */
            ii(0x100e_b131, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_b134, 3); mov(eax, memd[ds, eax + 39]);           /* mov eax, [eax+0x27] */
            ii(0x100e_b137, 5); call(Definitions.sys_delete, 0x7_ae28); /* call 0x10165f64 */
            ii(0x100e_b13c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_b13f, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100e_b142, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100e_b145, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b147, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_b148, 1); pop(edi);                               /* pop edi */
            ii(0x100e_b149, 1); pop(esi);                               /* pop esi */
            ii(0x100e_b14a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_b14b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_b14c, 1); ret();                                  /* ret */
        }
    }
}
