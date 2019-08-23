using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_76c8-6ad0e1bf")]
        public void Method_1011_76c8()
        {
            ii(0x1011_76c8, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1011_76cd, 5); call(Definitions.sys_check_available_stack_size, 0x4_e680); /* call 0x10165d52 */
            ii(0x1011_76d2, 1); push(esi);                              /* push esi */
            ii(0x1011_76d3, 1); push(edi);                              /* push edi */
            ii(0x1011_76d4, 1); push(ebp);                              /* push ebp */
            ii(0x1011_76d5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_76d7, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1011_76dd, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_76e0, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1011_76e3, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1011_76e6, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1011_76e9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_76ec, 5); call(0x1013_aaa8, 0x2_33b7);            /* call 0x1013aaa8 */
            ii(0x1011_76f1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_76f4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1011_76f7, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_76fa, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_76fd, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_7700, 5); call(Definitions.my_ctor_0x101b_38f8, -0xa_1015); /* call 0x100766f0 */
            ii(0x1011_7705, 3); sub(eax, 0xc);                          /* sub eax, 0xc */
            ii(0x1011_7708, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_770b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1011_770e, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_7711, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_7714, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1011_7717, 5); call(Definitions.my_ctor_0x101b_4184, -0xa_0c2c); /* call 0x10076af0 */
            ii(0x1011_771c, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1011_771f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_7722, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_7725, 7); mov(memd[ds, eax + 0x2], 0x101b_6730);  /* mov dword [eax+0x2], 0x101b6730 */
            ii(0x1011_772c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_772f, 5); call(/* sys */ 0x1017_cee0, 0x6_57ac);  /* call 0x1017cee0 */
            ii(0x1011_7734, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_7736, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_7739, 3); mov(memd[ds, eax + 0x8], edx);          /* mov [eax+0x8], edx */
            ii(0x1011_773c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_773f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_7742, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x1011_7745, 5); call(0x1007_6630, -0xa_111a);           /* call 0x10076630 */
            ii(0x1011_774a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_774d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_7750, 3); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1011_7753, 5); call(0x1008_8b44, -0x8_ec14);           /* call 0x10088b44 */
            ii(0x1011_7758, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_775b, 4); mov(memb[ds, eax + 0x14], 0x1);         /* mov byte [eax+0x14], 0x1 */
            ii(0x1011_775f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_7762, 6); mov(memw[ds, eax + 0x6], 0xffff);       /* mov word [eax+0x6], 0xffff */
            ii(0x1011_7768, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_776b, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_776e, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_7771, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7773, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_7774, 1); pop(edi);                               /* pop edi */
            ii(0x1011_7775, 1); pop(esi);                               /* pop esi */
            ii(0x1011_7776, 1); ret();                                  /* ret */
        }
    }
}
