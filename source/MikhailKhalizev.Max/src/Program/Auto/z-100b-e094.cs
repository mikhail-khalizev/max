using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_e094-9967f291")]
        public void Method_100b_e094()
        {
            ii(0x100b_e094, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_e099, 5); calld(Definitions.sys_check_available_stack_size, 0xa_7cb4); /* call 0x10165d52 */
            ii(0x100b_e09e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_e09f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_e0a0, 1); pushd(esi);                             /* push esi */
            ii(0x100b_e0a1, 1); pushd(edi);                             /* push edi */
            ii(0x100b_e0a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_e0a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_e0a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_e0ab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_e0ae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_e0b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e0b4, 5); calld(0x1007_6338, -0x4_7d81);          /* call 0x10076338 */
            ii(0x100b_e0b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_e0bb, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_e0be, 5); calld(0x1007_64b8, -0x4_7c0b);          /* call 0x100764b8 */
            ii(0x100b_e0c3, 2); jmpd(0x100b_e0cd, 0x8); goto l_0x100b_e0cd; /* jmp 0x100be0cd */
        l_0x100b_e0c5:
            ii(0x100b_e0c5, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_e0c8, 5); calld(0x1007_6bf8, -0x4_74d5);          /* call 0x10076bf8 */
        l_0x100b_e0cd:
            ii(0x100b_e0cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e0cf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_e0d2, 5); calld(0x1013_ad71, 0x7_cc9a);           /* call 0x1013ad71 */
            ii(0x100b_e0d7, 2); test(al, al);                           /* test al, al */
            ii(0x100b_e0d9, 2); if(jzd(0x100b_e133, 0x58)) goto l_0x100b_e133; /* jz 0x100be133 */
            ii(0x100b_e0db, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_e0de, 5); calld(0x1007_63a0, -0x4_7d43);          /* call 0x100763a0 */
            ii(0x100b_e0e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e0e5, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_e0e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_e0eb, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_e0ee, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_e0f0, 2); if(jnzd(0x100b_e103, 0x11)) goto l_0x100b_e103; /* jnz 0x100be103 */
            ii(0x100b_e0f2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_e0f5, 5); calld(0x1007_63d4, -0x4_7d26);          /* call 0x100763d4 */
            ii(0x100b_e0fa, 5); calld(0x100a_2edb, -0x1_b224);          /* call 0x100a2edb */
            ii(0x100b_e0ff, 2); test(al, al);                           /* test al, al */
            ii(0x100b_e101, 2); if(jnzd(0x100b_e105, 0x2)) goto l_0x100b_e105; /* jnz 0x100be105 */
        l_0x100b_e103:
            ii(0x100b_e103, 2); jmpd(0x100b_e119, 0x14); goto l_0x100b_e119; /* jmp 0x100be119 */
        l_0x100b_e105:
            ii(0x100b_e105, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_e108, 5); calld(0x1007_63a0, -0x4_7d6d);          /* call 0x100763a0 */
            ii(0x100b_e10d, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_e110, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_e115, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_e117, 2); if(jnzd(0x100b_e11b, 0x2)) goto l_0x100b_e11b; /* jnz 0x100be11b */
        l_0x100b_e119:
            ii(0x100b_e119, 2); jmpd(0x100b_e131, 0x16); goto l_0x100b_e131; /* jmp 0x100be131 */
        l_0x100b_e11b:
            ii(0x100b_e11b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_e11e, 5); calld(0x1007_63d4, -0x4_7d4f);          /* call 0x100763d4 */
            ii(0x100b_e123, 5); mov(ebx, 0x101c_3180);                  /* mov ebx, 0x101c3180 */
            ii(0x100b_e128, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_e12a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_e12c, 5); calld(0x100a_4550, -0x1_9be1);          /* call 0x100a4550 */
        l_0x100b_e131:
            ii(0x100b_e131, 2); jmpd(0x100b_e0c5, -0x6e); goto l_0x100b_e0c5; /* jmp 0x100be0c5 */
        l_0x100b_e133:
            ii(0x100b_e133, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e135, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_e138, 5); calld(0x1007_5f6c, -0x4_81d1);          /* call 0x10075f6c */
            ii(0x100b_e13d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_e13f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_e140, 1); popd(edi);                              /* pop edi */
            ii(0x100b_e141, 1); popd(esi);                              /* pop esi */
            ii(0x100b_e142, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_e143, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_e144, 1); retd(); return;                         /* ret */
        }
    }
}
