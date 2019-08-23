using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b268-a8e20d24")]
        public void Method_1007_b268()
        {
            ii(0x1007_b268, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_b26d, 5); calld(Definitions.sys_check_available_stack_size, 0xe_aae0); /* call 0x10165d52 */
            ii(0x1007_b272, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_b273, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_b274, 1); pushd(edx);                             /* push edx */
            ii(0x1007_b275, 1); pushd(esi);                             /* push esi */
            ii(0x1007_b276, 1); pushd(edi);                             /* push edi */
            ii(0x1007_b277, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_b278, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_b27a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_b280, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_b283, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b286, 4); mov(dx, memw_a32[ds, eax + 0x27]);      /* mov dx, [eax+0x27] */
            ii(0x1007_b28a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b28d, 4); cmp(dx, memw_a32[ds, eax + 0x25]);      /* cmp dx, [eax+0x25] */
            ii(0x1007_b291, 2); if(jled(0x1007_b2a4, 0x11)) goto l_0x1007_b2a4; /* jle 0x1007b2a4 */
            ii(0x1007_b293, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_b295, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b298, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b29b, 5); calld(0x1013_ad71, 0xb_fad1);           /* call 0x1013ad71 */
            ii(0x1007_b2a0, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b2a2, 2); if(jnzd(0x1007_b2a6, 0x2)) goto l_0x1007_b2a6; /* jnz 0x1007b2a6 */
        l_0x1007_b2a4:
            ii(0x1007_b2a4, 2); jmpd(0x1007_b2c2, 0x1c); goto l_0x1007_b2c2; /* jmp 0x1007b2c2 */
        l_0x1007_b2a6:
            ii(0x1007_b2a6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b2a9, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b2ac, 5); calld(0x1008_a228, 0xef77);             /* call 0x1008a228 */
            ii(0x1007_b2b1, 5); calld(0x1008_a370, 0xf0ba);             /* call 0x1008a370 */
            ii(0x1007_b2b6, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1007_b2b9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_b2be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_b2c0, 2); if(jgd(0x1007_b2c4, 0x2)) goto l_0x1007_b2c4; /* jg 0x1007b2c4 */
        l_0x1007_b2c2:
            ii(0x1007_b2c2, 2); jmpd(0x1007_b2ca, 0x6); goto l_0x1007_b2ca; /* jmp 0x1007b2ca */
        l_0x1007_b2c4:
            ii(0x1007_b2c4, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1007_b2c8, 2); jmpd(0x1007_b2ce, 0x4); goto l_0x1007_b2ce; /* jmp 0x1007b2ce */
        l_0x1007_b2ca:
            ii(0x1007_b2ca, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1007_b2ce:
            ii(0x1007_b2ce, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1007_b2d1, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1007_b2d4, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1007_b2d7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b2d9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_b2da, 1); popd(edi);                              /* pop edi */
            ii(0x1007_b2db, 1); popd(esi);                              /* pop esi */
            ii(0x1007_b2dc, 1); popd(edx);                              /* pop edx */
            ii(0x1007_b2dd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_b2de, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_b2df, 1); retd();                                 /* ret */
        }
    }
}
