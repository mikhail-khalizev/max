using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_3635-21ae2a28")]
        public void Method_1015_3635()
        {
            ii(0x1015_3635, 5); push(0x30);                             /* push 0x30 */
            ii(0x1015_363a, 5); call(Definitions.sys_check_available_stack_size, 0x1_2713); /* call 0x10165d52 */
            ii(0x1015_363f, 1); push(ebx);                              /* push ebx */
            ii(0x1015_3640, 1); push(ecx);                              /* push ecx */
            ii(0x1015_3641, 1); push(edx);                              /* push edx */
            ii(0x1015_3642, 1); push(esi);                              /* push esi */
            ii(0x1015_3643, 1); push(edi);                              /* push edi */
            ii(0x1015_3644, 1); push(ebp);                              /* push ebp */
            ii(0x1015_3645, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_3647, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1015_364d, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_3650, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3653, 4); cmp(memb[ds, eax + 0x3e], 0x23);        /* cmp byte [eax+0x3e], 0x23 */
            ii(0x1015_3657, 6); if(jnz(0x1015_371e, 0xc1)) goto l_0x1015_371e; /* jnz 0x1015371e */
            ii(0x1015_365d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3660, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_3663, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_3666, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3669, 3); mov(edx, memd[ds, edx + 0x18]);         /* mov edx, [edx+0x18] */
            ii(0x1015_366c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_366f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_3672, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_3675, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_3677, 1); cwde();                                 /* cwde */
            ii(0x1015_3678, 5); call(0x1007_3f48, -0xd_f735);           /* call 0x10073f48 */
            ii(0x1015_367d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_367f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_3682, 5); call(0x1007_66ac, -0xd_cfdb);           /* call 0x100766ac */
            ii(0x1015_3687, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_368a, 5); call(0x1007_6574, -0xd_d11b);           /* call 0x10076574 */
            ii(0x1015_368f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3692, 4); mov(dx, memw[ds, edx + 0x1a]);          /* mov dx, [edx+0x1a] */
            ii(0x1015_3696, 4); cmp(dx, memw[ds, eax + 0x1a]);          /* cmp dx, [eax+0x1a] */
            ii(0x1015_369a, 2); if(jnz(0x1015_36dd, 0x41)) goto l_0x1015_36dd; /* jnz 0x101536dd */
            ii(0x1015_369c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_369f, 5); call(0x1007_6574, -0xd_d130);           /* call 0x10076574 */
            ii(0x1015_36a4, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_36a7, 4); mov(dx, memw[ds, edx + 0x1c]);          /* mov dx, [edx+0x1c] */
            ii(0x1015_36ab, 4); cmp(dx, memw[ds, eax + 0x1c]);          /* cmp dx, [eax+0x1c] */
            ii(0x1015_36af, 2); if(jnz(0x1015_36c7, 0x16)) goto l_0x1015_36c7; /* jnz 0x101536c7 */
            ii(0x1015_36b1, 7); mov(memd[ss, ebp - 0x10], 0x3);         /* mov dword [ebp-0x10], 0x3 */
            ii(0x1015_36b8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_36ba, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_36bd, 5); call(0x1007_5f2c, -0xd_d796);           /* call 0x10075f2c */
            ii(0x1015_36c2, 5); jmp(0x1015_3788, 0xc1); goto l_0x1015_3788; /* jmp 0x10153788 */
        l_0x1015_36c7:
            ii(0x1015_36c7, 7); mov(memd[ss, ebp - 0x10], 0x1);         /* mov dword [ebp-0x10], 0x1 */
            ii(0x1015_36ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_36d0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_36d3, 5); call(0x1007_5f2c, -0xd_d7ac);           /* call 0x10075f2c */
            ii(0x1015_36d8, 5); jmp(0x1015_3788, 0xab); goto l_0x1015_3788; /* jmp 0x10153788 */
        l_0x1015_36dd:
            ii(0x1015_36dd, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_36e0, 5); call(0x1007_6574, -0xd_d171);           /* call 0x10076574 */
            ii(0x1015_36e5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_36e8, 4); mov(dx, memw[ds, edx + 0x1c]);          /* mov dx, [edx+0x1c] */
            ii(0x1015_36ec, 4); cmp(dx, memw[ds, eax + 0x1c]);          /* cmp dx, [eax+0x1c] */
            ii(0x1015_36f0, 2); if(jnz(0x1015_3708, 0x16)) goto l_0x1015_3708; /* jnz 0x10153708 */
            ii(0x1015_36f2, 7); mov(memd[ss, ebp - 0x10], 0x5);         /* mov dword [ebp-0x10], 0x5 */
            ii(0x1015_36f9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_36fb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_36fe, 5); call(0x1007_5f2c, -0xd_d7d7);           /* call 0x10075f2c */
            ii(0x1015_3703, 5); jmp(0x1015_3788, 0x80); goto l_0x1015_3788; /* jmp 0x10153788 */
        l_0x1015_3708:
            ii(0x1015_3708, 7); mov(memd[ss, ebp - 0x10], 0x7);         /* mov dword [ebp-0x10], 0x7 */
            ii(0x1015_370f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3711, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_3714, 5); call(0x1007_5f2c, -0xd_d7ed);           /* call 0x10075f2c */
            ii(0x1015_3719, 5); jmp(0x1015_3788, 0x6a); goto l_0x1015_3788; /* jmp 0x10153788 */
        l_0x1015_371e:
            ii(0x1015_371e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3721, 4); mov(ax, memw[ds, edx + 0x41]);          /* mov ax, [edx+0x41] */
            ii(0x1015_3725, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1015_3728, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1015_372d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_3730, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3733, 4); mov(ax, memw[ds, edx + 0x43]);          /* mov ax, [edx+0x43] */
            ii(0x1015_3737, 3); shl(eax, 0x6);                          /* shl eax, 0x6 */
            ii(0x1015_373a, 5); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x1015_373f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_3742, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_3745, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3748, 4); cmp(ax, memw[ds, edx + 0x16]);          /* cmp ax, [edx+0x16] */
            ii(0x1015_374c, 2); if(jg(0x1015_376c, 0x1e)) goto l_0x1015_376c; /* jg 0x1015376c */
            ii(0x1015_374e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_3751, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3754, 4); cmp(ax, memw[ds, edx + 0x18]);          /* cmp ax, [edx+0x18] */
            ii(0x1015_3758, 2); if(jg(0x1015_3763, 0x9)) goto l_0x1015_3763; /* jg 0x10153763 */
            ii(0x1015_375a, 7); mov(memd[ss, ebp - 0x10], 0x7);         /* mov dword [ebp-0x10], 0x7 */
            ii(0x1015_3761, 2); jmp(0x1015_3788, 0x25); goto l_0x1015_3788; /* jmp 0x10153788 */
        l_0x1015_3763:
            ii(0x1015_3763, 7); mov(memd[ss, ebp - 0x10], 0x5);         /* mov dword [ebp-0x10], 0x5 */
            ii(0x1015_376a, 2); jmp(0x1015_3788, 0x1c); goto l_0x1015_3788; /* jmp 0x10153788 */
        l_0x1015_376c:
            ii(0x1015_376c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_376f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_3772, 4); cmp(ax, memw[ds, edx + 0x18]);          /* cmp ax, [edx+0x18] */
            ii(0x1015_3776, 2); if(jg(0x1015_3781, 0x9)) goto l_0x1015_3781; /* jg 0x10153781 */
            ii(0x1015_3778, 7); mov(memd[ss, ebp - 0x10], 0x1);         /* mov dword [ebp-0x10], 0x1 */
            ii(0x1015_377f, 2); jmp(0x1015_3788, 0x7); goto l_0x1015_3788; /* jmp 0x10153788 */
        l_0x1015_3781:
            ii(0x1015_3781, 7); mov(memd[ss, ebp - 0x10], 0x3);         /* mov dword [ebp-0x10], 0x3 */
        l_0x1015_3788:
            ii(0x1015_3788, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1015_378b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_378d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_378e, 1); pop(edi);                               /* pop edi */
            ii(0x1015_378f, 1); pop(esi);                               /* pop esi */
            ii(0x1015_3790, 1); pop(edx);                               /* pop edx */
            ii(0x1015_3791, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_3792, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_3793, 1); ret();                                  /* ret */
        }
    }
}
