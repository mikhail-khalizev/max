using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_a2d6-98ffa081")]
        public void Method_100e_a2d6()
        {
            ii(0x100e_a2d6, 5); pushd(0xb4);                            /* push 0xb4 */
            ii(0x100e_a2db, 5); calld(Definitions.sys_check_available_stack_size, 0x7_ba72); /* call 0x10165d52 */
            ii(0x100e_a2e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_a2e1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_a2e2, 1); pushd(esi);                             /* push esi */
            ii(0x100e_a2e3, 1); pushd(edi);                             /* push edi */
            ii(0x100e_a2e4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_a2e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_a2e7, 6); sub(esp, 0x98);                         /* sub esp, 0x98 */
            ii(0x100e_a2ed, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_a2f0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_a2f3, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_a2f7, 3); lea(edi, ebp - 0x18);                   /* lea edi, [ebp-0x18] */
            ii(0x100e_a2fa, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x100e_a2fd, 3); lea(esi, esi + 0x2);                    /* lea esi, [esi+0x2] */
            ii(0x100e_a300, 2); movsw_a32();                            /* movsw */
            ii(0x100e_a302, 1); movsb_a32();                            /* movsb */
        l_0x100e_a303:
            ii(0x100e_a303, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100e_a307, 6); if(jnzd(0x100e_a3fe, 0xf1)) goto l_0x100e_a3fe; /* jnz 0x100ea3fe */
            ii(0x100e_a30d, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100e_a310, 1); pushd(eax);                             /* push eax */
            ii(0x100e_a311, 6); lea(ecx, ebp - 0x98);                   /* lea ecx, [ebp-0x98] */
            ii(0x100e_a317, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100e_a31c, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100e_a31f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_a322, 5); calld(0x100e_a18e, -0x199);             /* call 0x100ea18e */
            ii(0x100e_a327, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_a32a, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100e_a32d, 1); pushd(eax);                             /* push eax */
            ii(0x100e_a32e, 6); lea(ecx, ebp - 0x98);                   /* lea ecx, [ebp-0x98] */
            ii(0x100e_a334, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x100e_a339, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100e_a33c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_a33f, 5); calld(0x100e_a18e, -0x1b6);             /* call 0x100ea18e */
            ii(0x100e_a344, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_a347, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_a34a, 3); add(memb_a32[ss, ebp - 0x18], al);      /* add [ebp-0x18], al */
            ii(0x100e_a34d, 4); movsx(eax, memb_a32[ss, ebp - 0x18]);   /* movsx eax, byte [ebp-0x18] */
            ii(0x100e_a351, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_a353, 2); if(jld(0x100e_a35e, 0x9)) goto l_0x100e_a35e; /* jl 0x100ea35e */
            ii(0x100e_a355, 4); movsx(eax, memb_a32[ss, ebp - 0x18]);   /* movsx eax, byte [ebp-0x18] */
            ii(0x100e_a359, 3); cmp(eax, 0x1f);                         /* cmp eax, 0x1f */
            ii(0x100e_a35c, 2); if(jled(0x100e_a367, 0x9)) goto l_0x100e_a367; /* jle 0x100ea367 */
        l_0x100e_a35e:
            ii(0x100e_a35e, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_a362, 5); jmpd(0x100e_a3f9, 0x92); goto l_0x100e_a3f9; /* jmp 0x100ea3f9 */
        l_0x100e_a367:
            ii(0x100e_a367, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100e_a36a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_a36d, 5); calld(0x100e_a067, -0x30b);             /* call 0x100ea067 */
            ii(0x100e_a372, 2); test(al, al);                           /* test al, al */
            ii(0x100e_a374, 6); if(jnzd(0x100e_a3f9, 0x7f)) goto l_0x100e_a3f9; /* jnz 0x100ea3f9 */
            ii(0x100e_a37a, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_a37e, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100e_a381, 3); mov(memb_a32[ss, ebp - 0x17], al);      /* mov [ebp-0x17], al */
        l_0x100e_a384:
            ii(0x100e_a384, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100e_a388, 2); if(jzd(0x100e_a396, 0xc)) goto l_0x100e_a396; /* jz 0x100ea396 */
            ii(0x100e_a38a, 4); movsx(edx, memb_a32[ss, ebp - 0x17]);   /* movsx edx, byte [ebp-0x17] */
            ii(0x100e_a38e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_a392, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_a394, 2); if(jled(0x100e_a398, 0x2)) goto l_0x100e_a398; /* jle 0x100ea398 */
        l_0x100e_a396:
            ii(0x100e_a396, 2); jmpd(0x100e_a3f9, 0x61); goto l_0x100e_a3f9; /* jmp 0x100ea3f9 */
        l_0x100e_a398:
            ii(0x100e_a398, 4); movsx(eax, memb_a32[ss, ebp - 0x17]);   /* movsx eax, byte [ebp-0x17] */
            ii(0x100e_a39c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_a39e, 7); mov(al, memb_a32[ds, eax + ebp - 0x98]); /* mov al, [eax+ebp-0x98] */
            ii(0x100e_a3a5, 3); mov(memb_a32[ss, ebp - 0x16], al);      /* mov [ebp-0x16], al */
        l_0x100e_a3a8:
            ii(0x100e_a3a8, 4); movsx(eax, memb_a32[ss, ebp - 0x17]);   /* movsx eax, byte [ebp-0x17] */
            ii(0x100e_a3ac, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_a3ae, 4); mov(eax, memd_a32[ds, eax + ebp - 0x5a]); /* mov eax, [eax+ebp-0x5a] */
            ii(0x100e_a3b2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_a3b5, 4); movsx(edx, memb_a32[ss, ebp - 0x16]);   /* movsx edx, byte [ebp-0x16] */
            ii(0x100e_a3b9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_a3bb, 2); if(jgd(0x100e_a3cc, 0xf)) goto l_0x100e_a3cc; /* jg 0x100ea3cc */
            ii(0x100e_a3bd, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100e_a3c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_a3c3, 5); calld(0x100e_a067, -0x361);             /* call 0x100ea067 */
            ii(0x100e_a3c8, 2); test(al, al);                           /* test al, al */
            ii(0x100e_a3ca, 2); if(jzd(0x100e_a3ce, 0x2)) goto l_0x100e_a3ce; /* jz 0x100ea3ce */
        l_0x100e_a3cc:
            ii(0x100e_a3cc, 2); jmpd(0x100e_a3d6, 0x8); goto l_0x100e_a3d6; /* jmp 0x100ea3d6 */
        l_0x100e_a3ce:
            ii(0x100e_a3ce, 3); mov(al, memb_a32[ss, ebp - 0x16]);      /* mov al, [ebp-0x16] */
            ii(0x100e_a3d1, 3); inc(memb_a32[ss, ebp - 0x16]);          /* inc byte [ebp-0x16] */
            ii(0x100e_a3d4, 2); jmpd(0x100e_a3a8, -0x2e); goto l_0x100e_a3a8; /* jmp 0x100ea3a8 */
        l_0x100e_a3d6:
            ii(0x100e_a3d6, 4); movsx(eax, memb_a32[ss, ebp - 0x17]);   /* movsx eax, byte [ebp-0x17] */
            ii(0x100e_a3da, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_a3dc, 4); mov(eax, memd_a32[ds, eax + ebp - 0x5a]); /* mov eax, [eax+ebp-0x5a] */
            ii(0x100e_a3e0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_a3e3, 4); movsx(edx, memb_a32[ss, ebp - 0x16]);   /* movsx edx, byte [ebp-0x16] */
            ii(0x100e_a3e7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_a3e9, 2); if(jgd(0x100e_a3f1, 0x6)) goto l_0x100e_a3f1; /* jg 0x100ea3f1 */
            ii(0x100e_a3eb, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_a3ef, 2); jmpd(0x100e_a3f7, 0x6); goto l_0x100e_a3f7; /* jmp 0x100ea3f7 */
        l_0x100e_a3f1:
            ii(0x100e_a3f1, 3); mov(al, memb_a32[ss, ebp - 0x17]);      /* mov al, [ebp-0x17] */
            ii(0x100e_a3f4, 3); inc(memb_a32[ss, ebp - 0x17]);          /* inc byte [ebp-0x17] */
        l_0x100e_a3f7:
            ii(0x100e_a3f7, 2); jmpd(0x100e_a384, -0x75); goto l_0x100e_a384; /* jmp 0x100ea384 */
        l_0x100e_a3f9:
            ii(0x100e_a3f9, 5); jmpd(0x100e_a303, -0xfb); goto l_0x100e_a303; /* jmp 0x100ea303 */
        l_0x100e_a3fe:
            ii(0x100e_a3fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a400, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_a401, 1); popd(edi);                              /* pop edi */
            ii(0x100e_a402, 1); popd(esi);                              /* pop esi */
            ii(0x100e_a403, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_a404, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_a405, 1); retd(); return;                         /* ret */
        }
    }
}
