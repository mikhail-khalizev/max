using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_64f5-4e26f34")]
        public void Method_100c_64f5()
        {
            ii(0x100c_64f5, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_64fa, 5);  call(Definitions.sys_check_available_stack_size, 0x9_f853);/* call 0x10165d52 */
            ii(0x100c_64ff, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_6500, 1);  push(esi);                            /* push esi */
            ii(0x100c_6501, 1);  push(edi);                            /* push edi */
            ii(0x100c_6502, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_6503, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_6505, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100c_650b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_650e, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_6511, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100c_6514, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100c_6518, 5);  call(0x100c_dec2, 0x79a5);            /* call 0x100cdec2 */
            ii(0x100c_651d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_651f, 2);  if(jz(0x100c_653b, 0x1a)) goto l_0x100c_653b;/* jz 0x100c653b */
            ii(0x100c_6521, 4);  movsx(ebx, memb[ss, ebp - 4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x100c_6525, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_6529, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100c_652c, 5);  call(0x100c_7b27, 0x15f6);            /* call 0x100c7b27 */
            ii(0x100c_6531, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_6533, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6536, 5);  call(0x100c_ad68, 0x482d);            /* call 0x100cad68 */
        l_0x100c_653b:
            ii(0x100c_653b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_653d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_653e, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_653f, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_6540, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_6541, 1);  ret();                                /* ret */
        }
    }
}
