using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_46ce-f9eff030")]
        public void Method_1015_46ce()
        {
            ii(0x1015_46ce, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_46d3, 5); calld(Definitions.sys_check_available_stack_size, 0x1_167a); /* call 0x10165d52 */
            ii(0x1015_46d8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_46d9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_46da, 1); pushd(edx);                             /* push edx */
            ii(0x1015_46db, 1); pushd(esi);                             /* push esi */
            ii(0x1015_46dc, 1); pushd(edi);                             /* push edi */
            ii(0x1015_46dd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_46de, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_46e0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_46e6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_46e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_46ec, 3); dec(memb_a32[ds, eax + 0x58]);          /* dec byte [eax+0x58] */
            ii(0x1015_46ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_46f2, 4); cmp(memb_a32[ds, eax + 0x58], 0);       /* cmp byte [eax+0x58], 0x0 */
            ii(0x1015_46f6, 6); if(jzd(0x1015_4784, 0x88)) goto l_0x1015_4784; /* jz 0x10154784 */
            ii(0x1015_46fc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_46ff, 5); cmp(memw_a32[ds, eax + 0x8], 0x23);     /* cmp word [eax+0x8], 0x23 */
            ii(0x1015_4704, 2); if(jzd(0x1015_4710, 0xa)) goto l_0x1015_4710; /* jz 0x10154710 */
            ii(0x1015_4706, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4709, 5); cmp(memw_a32[ds, eax + 0x8], 0x37);     /* cmp word [eax+0x8], 0x37 */
            ii(0x1015_470e, 2); if(jnzd(0x1015_4712, 0x2)) goto l_0x1015_4712; /* jnz 0x10154712 */
        l_0x1015_4710:
            ii(0x1015_4710, 2); jmpd(0x1015_471c, 0xa); goto l_0x1015_471c; /* jmp 0x1015471c */
        l_0x1015_4712:
            ii(0x1015_4712, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4715, 5); cmp(memw_a32[ds, eax + 0x8], 0x44);     /* cmp word [eax+0x8], 0x44 */
            ii(0x1015_471a, 2); if(jnzd(0x1015_4751, 0x35)) goto l_0x1015_4751; /* jnz 0x10154751 */
        l_0x1015_471c:
            ii(0x1015_471c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_471f, 4); test(memb_a32[ds, eax + 0x58], 0x1);    /* test byte [eax+0x58], 0x1 */
            ii(0x1015_4723, 2); if(jzd(0x1015_472e, 0x9)) goto l_0x1015_472e; /* jz 0x1015472e */
            ii(0x1015_4725, 7); mov(memd_a32[ss, ebp - 0x8], 0xffff_fff8); /* mov dword [ebp-0x8], 0xfffffff8 */
            ii(0x1015_472c, 2); jmpd(0x1015_4735, 0x7); goto l_0x1015_4735; /* jmp 0x10154735 */
        l_0x1015_472e:
            ii(0x1015_472e, 7); mov(memd_a32[ss, ebp - 0x8], 0x8);      /* mov dword [ebp-0x8], 0x8 */
        l_0x1015_4735:
            ii(0x1015_4735, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4738, 6); mov(eax, memd_a32[ds, eax + 0xd5]);     /* mov eax, [eax+0xd5] */
            ii(0x1015_473e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_4741, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1015_4744, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_4747, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_474a, 5); calld(0x1014_9b9b, -0xabb4);            /* call 0x10149b9b */
            ii(0x1015_474f, 2); jmpd(0x1015_477f, 0x2e); goto l_0x1015_477f; /* jmp 0x1015477f */
        l_0x1015_4751:
            ii(0x1015_4751, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4754, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_4759, 2); if(jzd(0x1015_4765, 0xa)) goto l_0x1015_4765; /* jz 0x10154765 */
            ii(0x1015_475b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_475e, 5); cmp(memw_a32[ds, eax + 0x8], 0x43);     /* cmp word [eax+0x8], 0x43 */
            ii(0x1015_4763, 2); if(jnzd(0x1015_477f, 0x1a)) goto l_0x1015_477f; /* jnz 0x1015477f */
        l_0x1015_4765:
            ii(0x1015_4765, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4768, 7); mov(ax, memw_a32[ds, eax + 0xd5]);      /* mov ax, [eax+0xd5] */
            ii(0x1015_476f, 5); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1015_4774, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_4777, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_477a, 5); calld(0x1014_9b07, -0xac78);            /* call 0x10149b07 */
        l_0x1015_477f:
            ii(0x1015_477f, 5); jmpd(0x1015_484a, 0xc6); goto l_0x1015_484a; /* jmp 0x1015484a */
        l_0x1015_4784:
            ii(0x1015_4784, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4787, 4); test(memb_a32[ds, eax + 0x14], 0x2);    /* test byte [eax+0x14], 0x2 */
            ii(0x1015_478b, 2); if(jzd(0x1015_47e2, 0x55)) goto l_0x1015_47e2; /* jz 0x101547e2 */
            ii(0x1015_478d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4790, 4); test(memb_a32[ds, eax + 0x15], 0x2);    /* test byte [eax+0x15], 0x2 */
            ii(0x1015_4794, 2); if(jzd(0x1015_47b4, 0x1e)) goto l_0x1015_47b4; /* jz 0x101547b4 */
            ii(0x1015_4796, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4799, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_479b, 3); mov(dl, memb_a32[ds, eax + 0x2e]);      /* mov dl, [eax+0x2e] */
            ii(0x1015_479e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47a1, 4); mov(ax, memw_a32[ds, eax + 0x35]);      /* mov ax, [eax+0x35] */
            ii(0x1015_47a5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_47a7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_47aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47ad, 5); calld(0x1014_9b9b, -0xac17);            /* call 0x10149b9b */
            ii(0x1015_47b2, 2); jmpd(0x1015_47e2, 0x2e); goto l_0x1015_47e2; /* jmp 0x101547e2 */
        l_0x1015_47b4:
            ii(0x1015_47b4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47b7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_47b9, 3); mov(dl, memb_a32[ds, eax + 0x29]);      /* mov dl, [eax+0x29] */
            ii(0x1015_47bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47bf, 4); mov(ax, memw_a32[ds, eax + 0x33]);      /* mov ax, [eax+0x33] */
            ii(0x1015_47c3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_47c5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_47c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47cb, 5); calld(0x1014_9b07, -0xacc9);            /* call 0x10149b07 */
            ii(0x1015_47d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47d3, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_47d8, 2); if(jnzd(0x1015_47e2, 0x8)) goto l_0x1015_47e2; /* jnz 0x101547e2 */
            ii(0x1015_47da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47dd, 5); calld(0x1015_c894, 0x80b2);             /* call 0x1015c894 */
        l_0x1015_47e2:
            ii(0x1015_47e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47e5, 5); calld(0x1014_f08b, -0x575f);            /* call 0x1014f08b */
            ii(0x1015_47ea, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_47ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47f2, 5); calld(0x1007_6d98, -0xd_da5f);          /* call 0x10076d98 */
            ii(0x1015_47f7, 2); test(al, al);                           /* test al, al */
            ii(0x1015_47f9, 2); if(jzd(0x1015_4803, 0x8)) goto l_0x1015_4803; /* jz 0x10154803 */
            ii(0x1015_47fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_47fe, 5); calld(0x1010_094d, -0x5_3eb6);          /* call 0x1010094d */
        l_0x1015_4803:
            ii(0x1015_4803, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4806, 4); test(memb_a32[ds, eax + 0x14], 0x4);    /* test byte [eax+0x14], 0x4 */
            ii(0x1015_480a, 2); if(jnzd(0x1015_482e, 0x22)) goto l_0x1015_482e; /* jnz 0x1015482e */
            ii(0x1015_480c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_480f, 3); mov(ebx, memd_a32[ds, eax + 0x41]);     /* mov ebx, [eax+0x41] */
            ii(0x1015_4812, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_4815, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4818, 3); mov(edx, memd_a32[ds, eax + 0x3f]);     /* mov edx, [eax+0x3f] */
            ii(0x1015_481b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_481e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4821, 5); calld(0x1014_eb48, -0x5cde);            /* call 0x1014eb48 */
            ii(0x1015_4826, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4829, 5); calld(0x1015_c802, 0x7fd4);             /* call 0x1015c802 */
        l_0x1015_482e:
            ii(0x1015_482e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4831, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1015_4834, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4839, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_483b, 2); if(jled(0x1015_484a, 0xd)) goto l_0x1015_484a; /* jle 0x1015484a */
            ii(0x1015_483d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_4842, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4845, 5); calld(0x1015_2605, -0x2245);            /* call 0x10152605 */
        l_0x1015_484a:
            ii(0x1015_484a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_484c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_484d, 1); popd(edi);                              /* pop edi */
            ii(0x1015_484e, 1); popd(esi);                              /* pop esi */
            ii(0x1015_484f, 1); popd(edx);                              /* pop edx */
            ii(0x1015_4850, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_4851, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_4852, 1); retd(); return;                         /* ret */
        }
    }
}
