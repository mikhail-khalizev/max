using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_830c-295ce6fb")]
        public void Method_1013_830c()
        {
            ii(0x1013_830c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_8311, 5); call(Definitions.sys_check_available_stack_size, 0x2_da3c); /* call 0x10165d52 */
            ii(0x1013_8316, 1); push(esi);                              /* push esi */
            ii(0x1013_8317, 1); push(edi);                              /* push edi */
            ii(0x1013_8318, 1); push(ebp);                              /* push ebp */
            ii(0x1013_8319, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_831b, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_8321, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_8324, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1013_8327, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_832a, 3); mov(memb[ss, ebp - 0x4], cl);           /* mov [ebp-0x4], cl */
            ii(0x1013_832d, 5); mov(eax, 0x4ff);                        /* mov eax, 0x4ff */
            ii(0x1013_8332, 5); call(0x1013_82da, -0x5d);               /* call 0x101382da */
            ii(0x1013_8337, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_833a, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_833d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_833f, 2); if(jl(0x1013_8363, 0x22)) goto l_0x1013_8363; /* jl 0x10138363 */
            ii(0x1013_8341, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_8344, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_8347, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_834a, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1013_834d, 5); call(0x1013_6dc2, -0x1590);             /* call 0x10136dc2 */
            ii(0x1013_8352, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_8355, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_8358, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_835b, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1013_835e, 5); call(0x1013_6e23, -0x1540);             /* call 0x10136e23 */
        l_0x1013_8363:
            ii(0x1013_8363, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_8366, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1013_8369, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1013_836c, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1013_836f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1013_8372, 5); call(/* sys */ 0x1016_b244, 0x3_2ecd);  /* call 0x1016b244 */
            ii(0x1013_8377, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_837a, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_837d, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_8380, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1013_8383, 5); call(0x1013_6d90, -0x15f8);             /* call 0x10136d90 */
            ii(0x1013_8388, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_838c, 2); if(jz(0x1013_83d0, 0x42)) goto l_0x1013_83d0; /* jz 0x101383d0 */
            ii(0x1013_838e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_8391, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_8394, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_8397, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1013_839a, 3); add(eax, 0x2f);                         /* add eax, 0x2f */
            ii(0x1013_839d, 5); call(Definitions.sys_strlen, 0x3_9b25); /* call 0x10171ec7 */
            ii(0x1013_83a2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_83a4, 2); if(jnz(0x1013_83bf, 0x19)) goto l_0x1013_83bf; /* jnz 0x101383bf */
            ii(0x1013_83a6, 5); mov(edx, 0x101c_70fc);                  /* mov edx, 0x101c70fc */
            ii(0x1013_83ab, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_83ae, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_83b1, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_83b4, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1013_83b7, 3); mov(eax, memd[ds, eax + 0x4f]);         /* mov eax, [eax+0x4f] */
            ii(0x1013_83ba, 5); call(0x100e_b14d, -0x4_d272);           /* call 0x100eb14d */
        l_0x1013_83bf:
            ii(0x1013_83bf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_83c2, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_83c5, 3); imul(eax, eax, 0x53);                   /* imul eax, eax, 0x53 */
            ii(0x1013_83c8, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1013_83cb, 5); call(0x1013_6df4, -0x15dc);             /* call 0x10136df4 */
        l_0x1013_83d0:
            ii(0x1013_83d0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_83d2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_83d3, 1); pop(edi);                               /* pop edi */
            ii(0x1013_83d4, 1); pop(esi);                               /* pop esi */
            ii(0x1013_83d5, 1); ret();                                  /* ret */
        }
    }
}
