using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_5199-2840c621")]
        public void Method_1008_5199()
        {
            ii(0x1008_5199, 5); push(0x34);                             /* push 0x34 */
            ii(0x1008_519e, 5); call(Definitions.sys_check_available_stack_size, 0xe_0baf); /* call 0x10165d52 */
            ii(0x1008_51a3, 1); push(ebx);                              /* push ebx */
            ii(0x1008_51a4, 1); push(ecx);                              /* push ecx */
            ii(0x1008_51a5, 1); push(esi);                              /* push esi */
            ii(0x1008_51a6, 1); push(edi);                              /* push edi */
            ii(0x1008_51a7, 1); push(ebp);                              /* push ebp */
            ii(0x1008_51a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_51aa, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_51b0, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_51b3, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_51b6, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_51b9, 3); add(edx, 0x3e);                         /* add edx, 0x3e */
            ii(0x1008_51bc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_51bf, 5); call(0x1007_6d98, -0xe42c);             /* call 0x10076d98 */
            ii(0x1008_51c4, 2); test(al, al);                           /* test al, al */
            ii(0x1008_51c6, 2); if(jz(0x1008_51d5, 0xd)) goto l_0x1008_51d5; /* jz 0x100851d5 */
            ii(0x1008_51c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_51ca, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_51cd, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_51d0, 5); call(0x1007_6630, -0xeba5);             /* call 0x10076630 */
        l_0x1008_51d5:
            ii(0x1008_51d5, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_51d8, 3); add(edx, 0x32);                         /* add edx, 0x32 */
            ii(0x1008_51db, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_51de, 5); call(0x1007_6d98, -0xe44b);             /* call 0x10076d98 */
            ii(0x1008_51e3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_51e5, 2); if(jz(0x1008_5214, 0x2d)) goto l_0x1008_5214; /* jz 0x10085214 */
            ii(0x1008_51e7, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_51ea, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_51ed, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_51f0, 5); call(0x1007_6574, -0xec81);             /* call 0x10076574 */
            ii(0x1008_51f5, 5); call(0x1015_27b8, 0xc_d5be);            /* call 0x101527b8 */
            ii(0x1008_51fa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_51fc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_51ff, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1008_5202, 5); call(0x1007_6630, -0xebd7);             /* call 0x10076630 */
            ii(0x1008_5207, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_5209, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_520c, 3); add(eax, 0x36);                         /* add eax, 0x36 */
            ii(0x1008_520f, 5); call(0x1008_afe4, 0x5dd0);              /* call 0x1008afe4 */
        l_0x1008_5214:
            ii(0x1008_5214, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_5217, 5); call(0x1008_acf8, 0x5adc);              /* call 0x1008acf8 */
            ii(0x1008_521c, 2); test(al, al);                           /* test al, al */
            ii(0x1008_521e, 2); if(jnz(0x1008_5272, 0x52)) goto l_0x1008_5272; /* jnz 0x10085272 */
            ii(0x1008_5220, 5); call(0x1008_a7bc, 0x5597);              /* call 0x1008a7bc */
            ii(0x1008_5225, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_522a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_522d, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1008_5232, 5); call(Definitions.sys_new, 0xe_0bc9);    /* call 0x10165e00 */
            ii(0x1008_5237, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_523a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_523d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_5240, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1008_5244, 2); if(jz(0x1008_525c, 0x16)) goto l_0x1008_525c; /* jz 0x1008525c */
            ii(0x1008_5246, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_5249, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_524c, 5); call(0x100a_3711, 0x1_e4c0);            /* call 0x100a3711 */
            ii(0x1008_5251, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_5254, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_5257, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_525a, 2); jmp(0x1008_5262, 0x6); goto l_0x1008_5262; /* jmp 0x10085262 */
        l_0x1008_525c:
            ii(0x1008_525c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_525f, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1008_5262:
            ii(0x1008_5262, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1008_5265, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_526a, 3); mov(ebx, memd[ss, ebp - 0xc]);          /* mov ebx, [ebp-0xc] */
            ii(0x1008_526d, 5); call(0x100a_4db6, 0x1_fb44);            /* call 0x100a4db6 */
        l_0x1008_5272:
            ii(0x1008_5272, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_5274, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_5275, 1); pop(edi);                               /* pop edi */
            ii(0x1008_5276, 1); pop(esi);                               /* pop esi */
            ii(0x1008_5277, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_5278, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_5279, 1); ret();                                  /* ret */
        }
    }
}
