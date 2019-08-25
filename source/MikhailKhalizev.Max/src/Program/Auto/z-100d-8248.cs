using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_8248-65759e97")]
        public void Method_100d_8248()
        {
            ii(0x100d_8248, 5); push(0x30);                             /* push 0x30 */
            ii(0x100d_824d, 5); call(Definitions.sys_check_available_stack_size, 0x8_db00); /* call 0x10165d52 */
            ii(0x100d_8252, 1); push(esi);                              /* push esi */
            ii(0x100d_8253, 1); push(edi);                              /* push edi */
            ii(0x100d_8254, 1); push(ebp);                              /* push ebp */
            ii(0x100d_8255, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8257, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100d_825d, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x100d_8260, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100d_8263, 3); mov(memd[ss, ebp - 0x10], ebx);         /* mov [ebp-0x10], ebx */
            ii(0x100d_8266, 3); mov(memd[ss, ebp - 0x8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100d_8269, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100d_826d, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_8271, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_8273, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x100d_8276, 3); fild(memd[ss, ebp - 0x14]);             /* fild dword [ebp-0x14] */
            ii(0x100d_8279, 3); fstp(memq[ss, ebp - 0x1c]);             /* fstp qword [ebp-0x1c] */
            ii(0x100d_827c, 4); cmp(memb[ss, ebp - 0x4], 0x9);          /* cmp byte [ebp-0x4], 0x9 */
            ii(0x100d_8280, 2); if(jnz(0x100d_82b3, 0x31)) goto l_0x100d_82b3; /* jnz 0x100d82b3 */
            ii(0x100d_8282, 4); movsx(eax, memb[ss, ebp - 0x4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x100d_8286, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_8288, 6); fild(memw[ds, eax + 0x101b_7eb8]);      /* fild word [eax+0x101b7eb8] */
            ii(0x100d_828e, 3); fild(memw[ss, ebp - 0x8]);              /* fild word [ebp-0x8] */
            ii(0x100d_8291, 3); fdiv(memq[ss, ebp - 0x1c]);             /* fdiv qword [ebp-0x1c] */
            ii(0x100d_8294, 6); fld(memq[ds, 0x101b_5d98]);             /* fld qword [0x101b5d98] */
            ii(0x100d_829a, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x100d_829c, 5); call(Definitions.sys_pow, 0x9_41ff);    /* call 0x1016c4a0 */
            ii(0x100d_82a1, 2); fmulp(ST(1), ST(0));                    /* fmulp st1, st0 */
            ii(0x100d_82a3, 5); call(Definitions.sys_round, 0x8_ddd6);  /* call 0x1016607e */
            ii(0x100d_82a8, 3); fistp(memd[ss, ebp - 0x14]);            /* fistp dword [ebp-0x14] */
            ii(0x100d_82ab, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_82ae, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_82b1, 2); jmp(0x100d_82f4, 0x41); goto l_0x100d_82f4; /* jmp 0x100d82f4 */
        l_0x100d_82b3:
            ii(0x100d_82b3, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_82b7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100d_82ba, 2); if(jge(0x100d_82c5, 0x9)) goto l_0x100d_82c5; /* jge 0x100d82c5 */
            ii(0x100d_82bc, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100d_82c3, 2); jmp(0x100d_82f4, 0x2f); goto l_0x100d_82f4; /* jmp 0x100d82f4 */
        l_0x100d_82c5:
            ii(0x100d_82c5, 4); movsx(eax, memb[ss, ebp - 0x4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x100d_82c9, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100d_82cb, 6); fild(memw[ds, eax + 0x101b_7eb8]);      /* fild word [eax+0x101b7eb8] */
            ii(0x100d_82d1, 3); fild(memw[ss, ebp - 0x8]);              /* fild word [ebp-0x8] */
            ii(0x100d_82d4, 3); fdivr(memq[ss, ebp - 0x1c]);            /* fdivr qword [ebp-0x1c] */
            ii(0x100d_82d7, 6); fld(memq[ds, 0x101b_5d98]);             /* fld qword [0x101b5d98] */
            ii(0x100d_82dd, 2); fxch(ST(0), ST(1));                     /* fxch st0, st1 */
            ii(0x100d_82df, 5); call(Definitions.sys_pow, 0x9_41bc);    /* call 0x1016c4a0 */
            ii(0x100d_82e4, 2); fmulp(ST(1), ST(0));                    /* fmulp st1, st0 */
            ii(0x100d_82e6, 5); call(Definitions.sys_round, 0x8_dd93);  /* call 0x1016607e */
            ii(0x100d_82eb, 3); fistp(memd[ss, ebp - 0x14]);            /* fistp dword [ebp-0x14] */
            ii(0x100d_82ee, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_82f1, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x100d_82f4:
            ii(0x100d_82f4, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_82f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_82f9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_82fa, 1); pop(edi);                               /* pop edi */
            ii(0x100d_82fb, 1); pop(esi);                               /* pop esi */
            ii(0x100d_82fc, 1); ret();                                  /* ret */
        }
    }
}
