using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1ecf-b9536e55")]
        public void my_string_strstr_string()
        {
            ii(0x1014_1ecf, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_1ed4, 5);  call(Definitions.sys_check_available_stack_size, 0x2_3e79);/* call 0x10165d52 */
            ii(0x1014_1ed9, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_1eda, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_1edb, 1);  push(esi);                            /* push esi */
            ii(0x1014_1edc, 1);  push(edi);                            /* push edi */
            ii(0x1014_1edd, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_1ede, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_1ee0, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_1ee6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_1ee9, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_1eec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_1eef, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_1ef1, 5);  call(Definitions.my_strobj_c_str, -0xb_86fa);/* call 0x100897fc */
            ii(0x1014_1ef6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_1ef8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_1efb, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_1efd, 5);  call(Definitions.my_strobj_c_str, -0xb_8706);/* call 0x100897fc */
            ii(0x1014_1f02, 5);  call(Definitions.sys_strstr, 0x3_7109);/* call 0x10179010 */
            ii(0x1014_1f07, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_1f0a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_1f0d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_1f0f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_1f10, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_1f11, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_1f12, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_1f13, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_1f14, 1);  ret();                                /* ret */
        }
    }
}
