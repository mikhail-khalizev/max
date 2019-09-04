using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4f55-224ada98")]
        public void Method_100f_4f55()
        {
            ii(0x100f_4f55, 5); push(0x20);                             /* push 0x20 */
            ii(0x100f_4f5a, 5); call(Definitions.sys_check_available_stack_size, 0x7_0df3); /* call 0x10165d52 */
            ii(0x100f_4f5f, 1); push(ebx);                              /* push ebx */
            ii(0x100f_4f60, 1); push(ecx);                              /* push ecx */
            ii(0x100f_4f61, 1); push(edx);                              /* push edx */
            ii(0x100f_4f62, 1); push(esi);                              /* push esi */
            ii(0x100f_4f63, 1); push(edi);                              /* push edi */
            ii(0x100f_4f64, 1); push(ebp);                              /* push ebp */
            ii(0x100f_4f65, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4f67, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100f_4f6d, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x100f_4f70, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100f_4f73, 5); mov(memb[ds, 0x101c_388d], al);         /* mov [0x101c388d], al */
            ii(0x100f_4f78, 5); mov(al, memb[ds, 0x101c_388d]);         /* mov al, [0x101c388d] */
            ii(0x100f_4f7d, 5); mov(memb[ds, 0x101b_8853], al);         /* mov [0x101b8853], al */
            ii(0x100f_4f82, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4f84, 6); mov(dl, memb[ds, 0x101c_388d]);         /* mov dl, [0x101c388d] */
            ii(0x100f_4f8a, 5); mov(eax, memd[ds, 0x101b_884f]);        /* mov eax, [0x101b884f] */
            ii(0x100f_4f8f, 5); call(0x100c_fb73, -0x2_5421);           /* call 0x100cfb73 */
            ii(0x100f_4f94, 5); call(0x100f_f5c1, 0xa628);              /* call 0x100ff5c1 */
            ii(0x100f_4f99, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_4f9b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_4f9c, 1); pop(edi);                               /* pop edi */
            ii(0x100f_4f9d, 1); pop(esi);                               /* pop esi */
            ii(0x100f_4f9e, 1); pop(edx);                               /* pop edx */
            ii(0x100f_4f9f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_4fa0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_4fa1, 1); ret();                                  /* ret */
        }
    }
}
