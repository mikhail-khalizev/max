using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_e702-57673c78")]
        public void Method_100d_e702()
        {
            ii(0x100d_e702, 5); push(0x20);                             /* push 0x20 */
            ii(0x100d_e707, 5); call(Definitions.sys_check_available_stack_size, 0x8_7646); /* call 0x10165d52 */
            ii(0x100d_e70c, 1); push(ebx);                              /* push ebx */
            ii(0x100d_e70d, 1); push(ecx);                              /* push ecx */
            ii(0x100d_e70e, 1); push(esi);                              /* push esi */
            ii(0x100d_e70f, 1); push(edi);                              /* push edi */
            ii(0x100d_e710, 1); push(ebp);                              /* push ebp */
            ii(0x100d_e711, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_e713, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_e719, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_e71c, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_e71f, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_e724, 5); call(/* sys */ 0x1016_a24c, 0x8_bb23);  /* call 0x1016a24c */
            ii(0x100d_e729, 5); cmp(memw[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x100d_e72e, 6); if(jz(0x100d_e7c2, 0x8e)) goto l_0x100d_e7c2; /* jz 0x100de7c2 */
            ii(0x100d_e734, 3); lea(edx, memd[ss, ebp - 0x4]);          /* lea edx, [ebp-0x4] */
            ii(0x100d_e737, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e73a, 5); add(eax, 0x3af);                        /* add eax, 0x3af */
            ii(0x100d_e73f, 5); call(0x1008_b268, -0x5_34dc);           /* call 0x1008b268 */
            ii(0x100d_e744, 1); cwde();                                 /* cwde */
            ii(0x100d_e745, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_e747, 2); if(jl(0x100d_e787, 0x3e)) goto l_0x100d_e787; /* jl 0x100de787 */
            ii(0x100d_e749, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_e74d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_e750, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_e752, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e755, 5); add(eax, 0x1cf);                        /* add eax, 0x1cf */
            ii(0x100d_e75a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_e75c, 5); call(0x1007_6730, -0x6_8031);           /* call 0x10076730 */
            ii(0x100d_e761, 3); mov(ebx, memd[ds, eax + 0x6]);          /* mov ebx, [eax+0x6] */
            ii(0x100d_e764, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100d_e767, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_e76c, 5); mov(eax, 0x19);                         /* mov eax, 0x19 */
            ii(0x100d_e771, 5); call(0x1007_1e00, -0x6_c976);           /* call 0x10071e00 */
            ii(0x100d_e776, 1); cwde();                                 /* cwde */
            ii(0x100d_e777, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x100d_e77a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e77d, 3); mov(eax, memd[ds, eax + 0x4d]);         /* mov eax, [eax+0x4d] */
            ii(0x100d_e780, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_e783, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x100d_e785, 2); if(jle(0x100d_e789, 0x2)) goto l_0x100d_e789; /* jle 0x100de789 */
        l_0x100d_e787:
            ii(0x100d_e787, 2); jmp(0x100d_e7ab, 0x22); goto l_0x100d_e7ab; /* jmp 0x100de7ab */
        l_0x100d_e789:
            ii(0x100d_e789, 5); call(0x100d_51e4, -0x95aa);             /* call 0x100d51e4 */
            ii(0x100d_e78e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_e790, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_e792, 5); call(0x100d_5204, -0x9593);             /* call 0x100d5204 */
            ii(0x100d_e797, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e799, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_e79b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e79e, 6); mov(eax, memd[ds, eax + 0x3db]);        /* mov eax, [eax+0x3db] */
            ii(0x100d_e7a4, 5); call(0x100c_fa7c, -0xed2d);             /* call 0x100cfa7c */
            ii(0x100d_e7a9, 2); jmp(0x100d_e7c2, 0x17); goto l_0x100d_e7c2; /* jmp 0x100de7c2 */
        l_0x100d_e7ab:
            ii(0x100d_e7ab, 5); call(0x100d_51c4, -0x95ec);             /* call 0x100d51c4 */
            ii(0x100d_e7b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e7b2, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_e7b4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e7b7, 6); mov(eax, memd[ds, eax + 0x3db]);        /* mov eax, [eax+0x3db] */
            ii(0x100d_e7bd, 5); call(0x100c_fb06, -0xecbc);             /* call 0x100cfb06 */
        l_0x100d_e7c2:
            ii(0x100d_e7c2, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_e7c6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_e7c9, 5); call(0x100d_a88b, -0x3f43);             /* call 0x100da88b */
            ii(0x100d_e7ce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_e7d0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_e7d1, 1); pop(edi);                               /* pop edi */
            ii(0x100d_e7d2, 1); pop(esi);                               /* pop esi */
            ii(0x100d_e7d3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_e7d4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_e7d5, 1); ret();                                  /* ret */
        }
    }
}
