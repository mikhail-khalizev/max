using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_f4eb-d8be877c")]
        public void Method_1010_f4eb()
        {
            ii(0x1010_f4eb, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1010_f4f0, 5); call(Definitions.sys_check_available_stack_size, 0x5_685d); /* call 0x10165d52 */
            ii(0x1010_f4f5, 1); push(ebx);                              /* push ebx */
            ii(0x1010_f4f6, 1); push(ecx);                              /* push ecx */
            ii(0x1010_f4f7, 1); push(esi);                              /* push esi */
            ii(0x1010_f4f8, 1); push(edi);                              /* push edi */
            ii(0x1010_f4f9, 1); push(ebp);                              /* push ebp */
            ii(0x1010_f4fa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f4fc, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_f502, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_f505, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1010_f508, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f50b, 5); call(0x1010_f382, -0x18e);              /* call 0x1010f382 */
            ii(0x1010_f510, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f513, 5); call(0x1010_f2cf, -0x249);              /* call 0x1010f2cf */
            ii(0x1010_f518, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f51b, 3); mov(al, memb[ds, eax + 0x14]);          /* mov al, [eax+0x14] */
            ii(0x1010_f51e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_f523, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_f526, 2); if(jnz(0x1010_f58d, 0x65)) goto l_0x1010_f58d; /* jnz 0x1010f58d */
            ii(0x1010_f528, 5); call(/* sys */ 0x1016_be34, 0x5_c907);  /* call 0x1016be34 */
            ii(0x1010_f52d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f530, 5); call(0x1010_e9a0, -0xb95);              /* call 0x1010e9a0 */
            ii(0x1010_f535, 5); call(0x100d_533c, -0x3_a1fe);           /* call 0x100d533c */
            ii(0x1010_f53a, 1); cwde();                                 /* cwde */
            ii(0x1010_f53b, 1); push(eax);                              /* push eax */
            ii(0x1010_f53c, 5); call(0x100d_5360, -0x3_a1e1);           /* call 0x100d5360 */
            ii(0x1010_f541, 1); cwde();                                 /* cwde */
            ii(0x1010_f542, 1); push(eax);                              /* push eax */
            ii(0x1010_f543, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_f545, 1); push(eax);                              /* push eax */
            ii(0x1010_f546, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_f548, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f54b, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_f54d, 3); mov(ebx, memd[ds, eax + 0xe]);          /* mov ebx, [eax+0xe] */
            ii(0x1010_f550, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_f553, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f556, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1010_f558, 5); mov(eax, 0x6c0);                        /* mov eax, 0x6c0 */
            ii(0x1010_f55d, 5); call(0x100e_8c51, -0x2_6911);           /* call 0x100e8c51 */
            ii(0x1010_f562, 5); mov(edx, StringDefinitions.ModemPlayMenu2); /* mov edx, 0x101a4642 */
            ii(0x1010_f567, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f56a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_f56c, 5); call(0x1010_c628, -0x2f49);             /* call 0x1010c628 */
            ii(0x1010_f571, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f574, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_f576, 5); call(0x1010_eda6, -0x7d5);              /* call 0x1010eda6 */
            ii(0x1010_f57b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f57e, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_f580, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1010_f583, 5); call(Definitions.sys_display_draw_0, 0x5_7efc); /* call 0x10167484 */
            ii(0x1010_f588, 5); call(/* sys */ 0x1016_bcc4, 0x5_c737);  /* call 0x1016bcc4 */
        l_0x1010_f58d:
            ii(0x1010_f58d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_f58f, 3); mov(dl, memb[ss, ebp - 0x4]);           /* mov dl, [ebp-0x4] */
            ii(0x1010_f592, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f595, 3); mov(al, memb[ds, eax + 0x14]);          /* mov al, [eax+0x14] */
            ii(0x1010_f598, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1010_f59a, 1); cwde();                                 /* cwde */
            ii(0x1010_f59b, 5); call(0x1010_e8be, -0xce2);              /* call 0x1010e8be */
            ii(0x1010_f5a0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_f5a2, 2); if(jz(0x1010_f5b0, 0xc)) goto l_0x1010_f5b0; /* jz 0x1010f5b0 */
            ii(0x1010_f5a4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f5a7, 7); mov(memd[ds, eax + 0x4], 0x1);          /* mov dword [eax+0x4], 0x1 */
            ii(0x1010_f5ae, 2); jmp(0x1010_f5cd, 0x1d); goto l_0x1010_f5cd; /* jmp 0x1010f5cd */
        l_0x1010_f5b0:
            ii(0x1010_f5b0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f5b3, 3); mov(al, memb[ds, eax + 0x14]);          /* mov al, [eax+0x14] */
            ii(0x1010_f5b6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_f5bb, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_f5be, 2); if(jnz(0x1010_f5c5, 0x5)) goto l_0x1010_f5c5; /* jnz 0x1010f5c5 */
            ii(0x1010_f5c0, 5); call(0x1010_e943, -0xc82);              /* call 0x1010e943 */
        l_0x1010_f5c5:
            ii(0x1010_f5c5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_f5c8, 5); call(0x1010_ef7f, -0x64e);              /* call 0x1010ef7f */
        l_0x1010_f5cd:
            ii(0x1010_f5cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f5cf, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_f5d0, 1); pop(edi);                               /* pop edi */
            ii(0x1010_f5d1, 1); pop(esi);                               /* pop esi */
            ii(0x1010_f5d2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_f5d3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_f5d4, 1); ret();                                  /* ret */
        }
    }
}
