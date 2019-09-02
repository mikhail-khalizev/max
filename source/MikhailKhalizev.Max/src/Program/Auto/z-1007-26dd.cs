using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_26dd-51d7a1b2")]
        public void Method_1007_26dd()
        {
            ii(0x1007_26dd, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_26e2, 5); call(Definitions.sys_check_available_stack_size, 0xf_366b); /* call 0x10165d52 */
            ii(0x1007_26e7, 1); push(ebx);                              /* push ebx */
            ii(0x1007_26e8, 1); push(ecx);                              /* push ecx */
            ii(0x1007_26e9, 1); push(edx);                              /* push edx */
            ii(0x1007_26ea, 1); push(esi);                              /* push esi */
            ii(0x1007_26eb, 1); push(edi);                              /* push edi */
            ii(0x1007_26ec, 1); push(ebp);                              /* push ebp */
            ii(0x1007_26ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_26ef, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_26f5, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_26f8, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_26ff, 2); jmp(0x1007_2707, 6); goto l_0x1007_2707; /* jmp 0x10072707 */
        l_0x1007_2701:
            ii(0x1007_2701, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_2704, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x1007_2707:
            ii(0x1007_2707, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1007_270b, 3); cmp(eax, 5);                            /* cmp eax, 0x5 */
            ii(0x1007_270e, 2); if(jae(0x1007_2733, 0x23)) goto l_0x1007_2733; /* jae 0x10072733 */
            ii(0x1007_2710, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1007_2713, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1007_2717, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1007_271a, 6); mov(eax, memd[ds, eax + 0x101b_77a0]);  /* mov eax, [eax+0x101b77a0] */
            ii(0x1007_2720, 5); call(0x1007_62cc, 0x3ba7);              /* call 0x100762cc */
            ii(0x1007_2725, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_2727, 2); if(jz(0x1007_2731, 8)) goto l_0x1007_2731; /* jz 0x10072731 */
            ii(0x1007_2729, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_272c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_272f, 2); jmp(0x1007_273a, 9); goto l_0x1007_273a; /* jmp 0x1007273a */
        l_0x1007_2731:
            ii(0x1007_2731, 2); jmp(0x1007_2701, -0x32); goto l_0x1007_2701; /* jmp 0x10072701 */
        l_0x1007_2733:
            ii(0x1007_2733, 7); mov(memd[ss, ebp - 12], 0xffff_ffff);   /* mov dword [ebp-0xc], 0xffffffff */
        l_0x1007_273a:
            ii(0x1007_273a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_273d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_273f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_2740, 1); pop(edi);                               /* pop edi */
            ii(0x1007_2741, 1); pop(esi);                               /* pop esi */
            ii(0x1007_2742, 1); pop(edx);                               /* pop edx */
            ii(0x1007_2743, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_2744, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_2745, 1); ret();                                  /* ret */
        }
    }
}
