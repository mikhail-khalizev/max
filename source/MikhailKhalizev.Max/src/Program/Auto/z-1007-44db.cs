using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_44db-6fc2e41e")]
        public void Method_1007_44db()
        {
            ii(0x1007_44db, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1007_44e0, 5); calld(Definitions.sys_check_available_stack_size, 0xf_186d); /* call 0x10165d52 */
            ii(0x1007_44e5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_44e6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_44e7, 1); pushd(esi);                             /* push esi */
            ii(0x1007_44e8, 1); pushd(edi);                             /* push edi */
            ii(0x1007_44e9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_44ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_44ec, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1007_44f2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_44f5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_44f8, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_44fc, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_4500, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_4505, 5); calld(0x1010_3541, 0x8_f037);           /* call 0x10103541 */
            ii(0x1007_450a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_450c, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_450f, 5); calld(0x1007_64b8, 0x1fa4);             /* call 0x100764b8 */
        l_0x1007_4514:
            ii(0x1007_4514, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_4516, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_4519, 5); calld(0x1013_ad71, 0xc_6853);           /* call 0x1013ad71 */
            ii(0x1007_451e, 2); test(al, al);                           /* test al, al */
            ii(0x1007_4520, 6); if(jzd(0x1007_4588, 0x62)) goto l_0x1007_4588; /* jz 0x10074588 */
            ii(0x1007_4526, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_4529, 5); calld(0x1007_63a0, 0x1e72);             /* call 0x100763a0 */
            ii(0x1007_452e, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1007_4532, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_4535, 2); jmpd(0x1007_4548, 0x11); goto l_0x1007_4548; /* jmp 0x10074548 */
        l_0x1007_4537:
            ii(0x1007_4537, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_453a, 5); calld(0x1007_6408, 0x1ec9);             /* call 0x10076408 */
            ii(0x1007_453f, 5); calld(0x1015_f2cc, 0xe_ad88);           /* call 0x1015f2cc */
            ii(0x1007_4544, 2); jmpd(0x1007_457e, 0x38); goto l_0x1007_457e; /* jmp 0x1007457e */
        l_0x1007_4546:
            ii(0x1007_4546, 2); jmpd(0x1007_457e, 0x36); goto l_0x1007_457e; /* jmp 0x1007457e */
        l_0x1007_4548:
            ii(0x1007_4548, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_454b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_454e, 5); cmp(memw_a32[ss, ebp - 0x14], 0x16);    /* cmp word [ebp-0x14], 0x16 */
            ii(0x1007_4553, 2); if(jbd(0x1007_4575, 0x20)) goto l_0x1007_4575; /* jb 0x10074575 */
            ii(0x1007_4555, 5); cmp(memw_a32[ss, ebp - 0x14], 0x16);    /* cmp word [ebp-0x14], 0x16 */
            ii(0x1007_455a, 2); if(jbed(0x1007_4537, -0x25)) goto l_0x1007_4537; /* jbe 0x10074537 */
            ii(0x1007_455c, 5); cmp(memw_a32[ss, ebp - 0x14], 0x21);    /* cmp word [ebp-0x14], 0x21 */
            ii(0x1007_4561, 2); if(jbd(0x1007_4573, 0x10)) goto l_0x1007_4573; /* jb 0x10074573 */
            ii(0x1007_4563, 5); cmp(memw_a32[ss, ebp - 0x14], 0x21);    /* cmp word [ebp-0x14], 0x21 */
            ii(0x1007_4568, 2); if(jbed(0x1007_4537, -0x33)) goto l_0x1007_4537; /* jbe 0x10074537 */
            ii(0x1007_456a, 5); cmp(memw_a32[ss, ebp - 0x14], 0x27);    /* cmp word [ebp-0x14], 0x27 */
            ii(0x1007_456f, 2); if(jzd(0x1007_4537, -0x3a)) goto l_0x1007_4537; /* jz 0x10074537 */
            ii(0x1007_4571, 2); jmpd(0x1007_4546, -0x2d); goto l_0x1007_4546; /* jmp 0x10074546 */
        l_0x1007_4573:
            ii(0x1007_4573, 2); jmpd(0x1007_4546, -0x2f); goto l_0x1007_4546; /* jmp 0x10074546 */
        l_0x1007_4575:
            ii(0x1007_4575, 5); cmp(memw_a32[ss, ebp - 0x14], 0x15);    /* cmp word [ebp-0x14], 0x15 */
            ii(0x1007_457a, 2); if(jzd(0x1007_4537, -0x45)) goto l_0x1007_4537; /* jz 0x10074537 */
            ii(0x1007_457c, 2); jmpd(0x1007_4546, -0x38); goto l_0x1007_4546; /* jmp 0x10074546 */
        l_0x1007_457e:
            ii(0x1007_457e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_4581, 5); calld(0x1007_6bf8, 0x2672);             /* call 0x10076bf8 */
            ii(0x1007_4586, 2); jmpd(0x1007_4514, -0x74); goto l_0x1007_4514; /* jmp 0x10074514 */
        l_0x1007_4588:
            ii(0x1007_4588, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_458a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_458d, 5); calld(0x1007_5f6c, 0x19da);             /* call 0x10075f6c */
            ii(0x1007_4592, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4594, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_4595, 1); popd(edi);                              /* pop edi */
            ii(0x1007_4596, 1); popd(esi);                              /* pop esi */
            ii(0x1007_4597, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_4598, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_4599, 1); retd(); return;                         /* ret */
        }
    }
}
