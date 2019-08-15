using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5d8c8d1-0a8f-46b6-a62a-711ede562abd")]
        public void Method_100b_2dfb()
        {
            ii(0x100b_2dfb, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_2e00, 5); calld(Definitions.sys_check_available_stack_size, 0xb_2f4d); /* call 0x10165d52 */
            ii(0x100b_2e05, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_2e06, 1); pushd(esi);                             /* push esi */
            ii(0x100b_2e07, 1); pushd(edi);                             /* push edi */
            ii(0x100b_2e08, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_2e09, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_2e0b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_2e11, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_2e14, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_2e17, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100b_2e1a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_2e1d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_2e20, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_2e24, 2); if(jnzd(0x100b_2e4e, 0x28)) goto l_0x100b_2e4e; /* jnz 0x100b2e4e */
            ii(0x100b_2e26, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2e29, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_2e2c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_2e31, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_2e33, 2); if(jled(0x100b_2e3b, 0x6)) goto l_0x100b_2e3b; /* jle 0x100b2e3b */
            ii(0x100b_2e35, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x100b_2e39, 2); jmpd(0x100b_2e3f, 0x4); goto l_0x100b_2e3f; /* jmp 0x100b2e3f */
        l_0x100b_2e3b:
            ii(0x100b_2e3b, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x100b_2e3f:
            ii(0x100b_2e3f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_2e41, 3); mov(dl, memb_a32[ss, ebp - 0x14]);      /* mov dl, [ebp-0x14] */
            ii(0x100b_2e44, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_2e47, 5); calld(0x100a_297d, -0x1_04cf);          /* call 0x100a297d */
            ii(0x100b_2e4c, 2); jmpd(0x100b_2e71, 0x23); goto l_0x100b_2e71; /* jmp 0x100b2e71 */
        l_0x100b_2e4e:
            ii(0x100b_2e4e, 4); cmp(memb_a32[ss, ebp - 0x4], 0x2);      /* cmp byte [ebp-0x4], 0x2 */
            ii(0x100b_2e52, 2); if(jnzd(0x100b_2e71, 0x1d)) goto l_0x100b_2e71; /* jnz 0x100b2e71 */
            ii(0x100b_2e54, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_2e57, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_2e5a, 5); calld(0x1008_a57c, -0x2_88e3);          /* call 0x1008a57c */
            ii(0x100b_2e5f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_2e61, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_2e64, 5); calld(0x100b_1814, -0x1655);            /* call 0x100b1814 */
            ii(0x100b_2e69, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_2e6c, 5); calld(0x100b_1e09, -0x1068);            /* call 0x100b1e09 */
        l_0x100b_2e71:
            ii(0x100b_2e71, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_2e73, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_2e74, 1); popd(edi);                              /* pop edi */
            ii(0x100b_2e75, 1); popd(esi);                              /* pop esi */
            ii(0x100b_2e76, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_2e77, 1); retd(); return;                         /* ret */
        }
    }
}
