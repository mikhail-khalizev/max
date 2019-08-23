using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3060-9b31d5e7")]
        public void Method_100b_3060()
        {
            ii(0x100b_3060, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100b_3065, 5); call(Definitions.sys_check_available_stack_size, 0xb_2ce8); /* call 0x10165d52 */
            ii(0x100b_306a, 1); push(esi);                              /* push esi */
            ii(0x100b_306b, 1); push(edi);                              /* push edi */
            ii(0x100b_306c, 1); push(ebp);                              /* push ebp */
            ii(0x100b_306d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_306f, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100b_3075, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_3078, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100b_307b, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100b_307e, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100b_3081, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100b_3085, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100b_3088, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_308b, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x100b_308e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100b_3090, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_3093, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_3096, 5); call(0x100a_26d1, -0x1_09ca);           /* call 0x100a26d1 */
            ii(0x100b_309b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_309e, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_30a1, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_30a4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_30a7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_30aa, 5); call(Definitions.my_ctor_0x101b_38f8, -0x3_c9bf); /* call 0x100766f0 */
            ii(0x100b_30af, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_30b2, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_30b5, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_30b8, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_30bb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_30be, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_30c1, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_c5d6); /* call 0x10076af0 */
            ii(0x100b_30c6, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x100b_30c9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_30cc, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_30cf, 7); mov(memd[ds, eax + 0x2], 0x101b_5344);  /* mov dword [eax+0x2], 0x101b5344 */
            ii(0x100b_30d6, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100b_30d9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_30dc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_30df, 5); call(0x1007_6630, -0x3_cab4);           /* call 0x10076630 */
            ii(0x100b_30e4, 3); mov(al, memb[ss, ebp + 0x10]);          /* mov al, [ebp+0x10] */
            ii(0x100b_30e7, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100b_30ea, 3); mov(memb[ds, edx + 0x21], al);          /* mov [edx+0x21], al */
            ii(0x100b_30ed, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_30f0, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_30f3, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_30f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_30f8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_30f9, 1); pop(edi);                               /* pop edi */
            ii(0x100b_30fa, 1); pop(esi);                               /* pop esi */
            ii(0x100b_30fb, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
