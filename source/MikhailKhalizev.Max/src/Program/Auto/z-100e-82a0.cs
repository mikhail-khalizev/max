using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_82a0-1d81a059")]
        public void Method_100e_82a0()
        {
            ii(0x100e_82a0, 5); push(0x54);                             /* push 0x54 */
            ii(0x100e_82a5, 5); call(Definitions.sys_check_available_stack_size, 0x7_daa8); /* call 0x10165d52 */
            ii(0x100e_82aa, 1); push(ebx);                              /* push ebx */
            ii(0x100e_82ab, 1); push(ecx);                              /* push ecx */
            ii(0x100e_82ac, 1); push(edx);                              /* push edx */
            ii(0x100e_82ad, 1); push(esi);                              /* push esi */
            ii(0x100e_82ae, 1); push(edi);                              /* push edi */
            ii(0x100e_82af, 1); push(ebp);                              /* push ebp */
            ii(0x100e_82b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_82b2, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100e_82b8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_82bb, 5); call(0x100e_86e8, 0x428);               /* call 0x100e86e8 */
            ii(0x100e_82c0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_82c3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_82c6, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x100e_82c9, 5); call(0x100e_5365, -0x2f69);             /* call 0x100e5365 */
            ii(0x100e_82ce, 3); sub(eax, 0x20);                         /* sub eax, 0x20 */
            ii(0x100e_82d1, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_82d4, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_82d7, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100e_82da, 5); call(0x100e_86e8, 0x409);               /* call 0x100e86e8 */
            ii(0x100e_82df, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_82e2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_82e5, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x100e_82e8, 5); call(0x100e_5365, -0x2f88);             /* call 0x100e5365 */
            ii(0x100e_82ed, 3); sub(eax, 0x2a);                         /* sub eax, 0x2a */
            ii(0x100e_82f0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_82f3, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_82f6, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100e_82f9, 5); call(0x100e_86e8, 0x3ea);               /* call 0x100e86e8 */
            ii(0x100e_82fe, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_8301, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_8304, 3); add(eax, 0x34);                         /* add eax, 0x34 */
            ii(0x100e_8307, 5); call(0x100e_5365, -0x2fa7);             /* call 0x100e5365 */
            ii(0x100e_830c, 3); sub(eax, 0x34);                         /* sub eax, 0x34 */
            ii(0x100e_830f, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_8312, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_8315, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100e_8318, 5); call(0x100e_86e8, 0x3cb);               /* call 0x100e86e8 */
            ii(0x100e_831d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_8320, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_8323, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x100e_8326, 5); call(0x100e_5365, -0x2fc6);             /* call 0x100e5365 */
            ii(0x100e_832b, 3); sub(eax, 0x3e);                         /* sub eax, 0x3e */
            ii(0x100e_832e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_8331, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_8334, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100e_8337, 5); call(0x100e_86e8, 0x3ac);               /* call 0x100e86e8 */
            ii(0x100e_833c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_833f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_8342, 3); add(eax, 0x48);                         /* add eax, 0x48 */
            ii(0x100e_8345, 5); call(0x100e_5365, -0x2fe5);             /* call 0x100e5365 */
            ii(0x100e_834a, 3); sub(eax, 0x48);                         /* sub eax, 0x48 */
            ii(0x100e_834d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_8350, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_8353, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100e_8356, 5); call(0x100e_86e8, 0x38d);               /* call 0x100e86e8 */
            ii(0x100e_835b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_835e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_8361, 3); add(eax, 0x52);                         /* add eax, 0x52 */
            ii(0x100e_8364, 5); call(0x100e_5365, -0x3004);             /* call 0x100e5365 */
            ii(0x100e_8369, 3); sub(eax, 0x52);                         /* sub eax, 0x52 */
            ii(0x100e_836c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_836f, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_8372, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_8375, 5); call(0x100e_86e8, 0x36e);               /* call 0x100e86e8 */
            ii(0x100e_837a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_837d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_8380, 3); add(eax, 0x5c);                         /* add eax, 0x5c */
            ii(0x100e_8383, 5); call(0x100e_5365, -0x3023);             /* call 0x100e5365 */
            ii(0x100e_8388, 3); sub(eax, 0x5c);                         /* sub eax, 0x5c */
            ii(0x100e_838b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_838e, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_8391, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_8394, 5); call(0x100e_86e8, 0x34f);               /* call 0x100e86e8 */
            ii(0x100e_8399, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_839c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_839f, 3); add(eax, 0x66);                         /* add eax, 0x66 */
            ii(0x100e_83a2, 5); call(0x100e_5365, -0x3042);             /* call 0x100e5365 */
            ii(0x100e_83a7, 3); sub(eax, 0x66);                         /* sub eax, 0x66 */
            ii(0x100e_83aa, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_83ad, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_83b0, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_83b3, 5); call(0x100e_86e8, 0x330);               /* call 0x100e86e8 */
            ii(0x100e_83b8, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_83bb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_83be, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x100e_83c1, 5); call(0x100e_5365, -0x3061);             /* call 0x100e5365 */
            ii(0x100e_83c6, 3); sub(eax, 0x70);                         /* sub eax, 0x70 */
            ii(0x100e_83c9, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_83cc, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_83cf, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_83d2, 5); call(0x100e_86e8, 0x311);               /* call 0x100e86e8 */
            ii(0x100e_83d7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_83da, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_83dd, 3); add(eax, 0x7a);                         /* add eax, 0x7a */
            ii(0x100e_83e0, 5); call(0x100e_5365, -0x3080);             /* call 0x100e5365 */
            ii(0x100e_83e5, 3); sub(eax, 0x7a);                         /* sub eax, 0x7a */
            ii(0x100e_83e8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_83eb, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_83ee, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_83f1, 5); call(0x100e_86e8, 0x2f2);               /* call 0x100e86e8 */
            ii(0x100e_83f6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_83f9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_83fc, 5); add(eax, 0x84);                         /* add eax, 0x84 */
            ii(0x100e_8401, 5); call(0x100e_5365, -0x30a1);             /* call 0x100e5365 */
            ii(0x100e_8406, 5); sub(eax, 0x84);                         /* sub eax, 0x84 */
            ii(0x100e_840b, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_840e, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_8411, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_8414, 5); call(0x100e_86e8, 0x2cf);               /* call 0x100e86e8 */
            ii(0x100e_8419, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_841c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_841f, 5); add(eax, 0x8e);                         /* add eax, 0x8e */
            ii(0x100e_8424, 5); call(0x100e_5365, -0x30c4);             /* call 0x100e5365 */
            ii(0x100e_8429, 5); sub(eax, 0x8e);                         /* sub eax, 0x8e */
            ii(0x100e_842e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_8431, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x100e_8434, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_8437, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_843a, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100e_843d, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100e_8440, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8442, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_8443, 1); pop(edi);                               /* pop edi */
            ii(0x100e_8444, 1); pop(esi);                               /* pop esi */
            ii(0x100e_8445, 1); pop(edx);                               /* pop edx */
            ii(0x100e_8446, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_8447, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_8448, 1); ret();                                  /* ret */
        }
    }
}
