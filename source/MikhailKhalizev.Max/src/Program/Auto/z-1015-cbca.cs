using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_cbca-b1a0da6c")]
        public void Method_1015_cbca()
        {
            ii(0x1015_cbca, 5); push(0x20);                             /* push 0x20 */
            ii(0x1015_cbcf, 5); call(Definitions.sys_check_available_stack_size, 0x917e); /* call 0x10165d52 */
            ii(0x1015_cbd4, 1); push(ebx);                              /* push ebx */
            ii(0x1015_cbd5, 1); push(ecx);                              /* push ecx */
            ii(0x1015_cbd6, 1); push(esi);                              /* push esi */
            ii(0x1015_cbd7, 1); push(edi);                              /* push edi */
            ii(0x1015_cbd8, 1); push(ebp);                              /* push ebp */
            ii(0x1015_cbd9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_cbdb, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1015_cbe1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_cbe4, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_cbe7, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1015_cbeb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cbee, 5); call(0x1007_2600, -0xe_a5f3);           /* call 0x10072600 */
            ii(0x1015_cbf3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cbf6, 4); mov(memb[ds, eax + 0x3e], 1);           /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_cbfa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cbfd, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_cc00, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_cc05, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_cc0b, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1015_cc11, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_cc16, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x1015_cc19, 2); if(jnz(0x1015_cc73, 0x58)) goto l_0x1015_cc73; /* jnz 0x1015cc73 */
            ii(0x1015_cc1b, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1015_cc20, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_cc22, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cc25, 5); call(0x1007_6204, -0xe_6a26);           /* call 0x10076204 */
            ii(0x1015_cc2a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_cc2c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cc2f, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_cc32, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_cc34, 1); cwde();                                 /* cwde */
            ii(0x1015_cc35, 5); call(0x1010_11ff, -0x5_ba3b);           /* call 0x101011ff */
            ii(0x1015_cc3a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cc3c, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_cc41, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_cc44, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cc47, 5); call(0x1007_6074, -0xe_6bd8);           /* call 0x10076074 */
            ii(0x1015_cc4c, 2); test(al, al);                           /* test al, al */
            ii(0x1015_cc4e, 2); if(jz(0x1015_cc58, 8)) goto l_0x1015_cc58; /* jz 0x1015cc58 */
            ii(0x1015_cc50, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cc53, 5); call(0x1014_9fa8, -0x1_2cb0);           /* call 0x10149fa8 */
        l_0x1015_cc58:
            ii(0x1015_cc58, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_cc5d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cc60, 5); call(0x1007_6d98, -0xe_5ecd);           /* call 0x10076d98 */
            ii(0x1015_cc65, 2); test(al, al);                           /* test al, al */
            ii(0x1015_cc67, 2); if(jz(0x1015_cc71, 8)) goto l_0x1015_cc71; /* jz 0x1015cc71 */
            ii(0x1015_cc69, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cc6c, 5); call(0x1010_094d, -0x5_c324);           /* call 0x1010094d */
        l_0x1015_cc71:
            ii(0x1015_cc71, 2); jmp(0x1015_ccc9, 0x56); goto l_0x1015_ccc9; /* jmp 0x1015ccc9 */
        l_0x1015_cc73:
            ii(0x1015_cc73, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_cc78, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cc7b, 5); call(0x1007_6d98, -0xe_5ee8);           /* call 0x10076d98 */
            ii(0x1015_cc80, 2); test(al, al);                           /* test al, al */
            ii(0x1015_cc82, 2); if(jz(0x1015_ccc9, 0x45)) goto l_0x1015_ccc9; /* jz 0x1015ccc9 */
            ii(0x1015_cc84, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cc87, 5); call(0x1010_094d, -0x5_c33f);           /* call 0x1010094d */
            ii(0x1015_cc8c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_cc8f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_cc91, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1015_cc94, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_cc96, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1015_cc9b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_cc9d, 2); if(jnz(0x1015_ccc1, 0x22)) goto l_0x1015_ccc1; /* jnz 0x1015ccc1 */
            ii(0x1015_cc9f, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1015_cca4, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1015_cca9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_ccac, 5); call(0x1007_6204, -0xe_6aad);           /* call 0x10076204 */
            ii(0x1015_ccb1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_ccb3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_ccb6, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_ccb9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_ccbb, 1); cwde();                                 /* cwde */
            ii(0x1015_ccbc, 5); call(0x1010_11ff, -0x5_bac2);           /* call 0x101011ff */
        l_0x1015_ccc1:
            ii(0x1015_ccc1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_ccc4, 5); call(0x1010_19b8, -0x5_b311);           /* call 0x101019b8 */
        l_0x1015_ccc9:
            ii(0x1015_ccc9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_cccb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_cccc, 1); pop(edi);                               /* pop edi */
            ii(0x1015_cccd, 1); pop(esi);                               /* pop esi */
            ii(0x1015_ccce, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_cccf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_ccd0, 1); ret();                                  /* ret */
        }
    }
}
