using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e7df-b953ef87")]
        public void Method_1010_e7df()
        {
            ii(0x1010_e7df, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1010_e7e4, 5); calld(Definitions.sys_check_available_stack_size, 0x5_7569); /* call 0x10165d52 */
            ii(0x1010_e7e9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_e7ea, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_e7eb, 1); pushd(edx);                             /* push edx */
            ii(0x1010_e7ec, 1); pushd(esi);                             /* push esi */
            ii(0x1010_e7ed, 1); pushd(edi);                             /* push edi */
            ii(0x1010_e7ee, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_e7ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e7f1, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_e7f7, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1010_e7fa, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1010_e7fe, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1010_e802, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1010_e806:
            ii(0x1010_e806, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1010_e80a, 2); if(jzd(0x1010_e82a, 0x1e)) goto l_0x1010_e82a; /* jz 0x1010e82a */
            ii(0x1010_e80c, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_e811, 5); calld(0x1010_bf06, -0x2910);            /* call 0x1010bf06 */
            ii(0x1010_e816, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_e818, 2); if(jnzd(0x1010_e826, 0xc)) goto l_0x1010_e826; /* jnz 0x1010e826 */
            ii(0x1010_e81a, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_e821, 5); jmpd(0x1010_e8b2, 0x8c); goto l_0x1010_e8b2; /* jmp 0x1010e8b2 */
        l_0x1010_e826:
            ii(0x1010_e826, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1010_e82a:
            ii(0x1010_e82a, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1010_e82e, 2); if(jzd(0x1010_e845, 0x15)) goto l_0x1010_e845; /* jz 0x1010e845 */
            ii(0x1010_e830, 5); calld(0x1010_d90b, -0xf2a);             /* call 0x1010d90b */
            ii(0x1010_e835, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_e837, 2); if(jzd(0x1010_e83f, 0x6)) goto l_0x1010_e83f; /* jz 0x1010e83f */
            ii(0x1010_e839, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1010_e83d, 2); jmpd(0x1010_e845, 0x6); goto l_0x1010_e845; /* jmp 0x1010e845 */
        l_0x1010_e83f:
            ii(0x1010_e83f, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1010_e843, 2); jmpd(0x1010_e888, 0x43); goto l_0x1010_e888; /* jmp 0x1010e888 */
        l_0x1010_e845:
            ii(0x1010_e845, 7); mov(memd_a32[ss, ebp - 0x18], 0x4);     /* mov dword [ebp-0x18], 0x4 */
        l_0x1010_e84c:
            ii(0x1010_e84c, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x1010_e84f, 5); cmp(memw_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* cmp word [ebp-0x18], 0xffff */
            ii(0x1010_e854, 2); if(jzd(0x1010_e871, 0x1b)) goto l_0x1010_e871; /* jz 0x1010e871 */
            ii(0x1010_e856, 5); mov(eax, 0x33);                         /* mov eax, 0x33 */
            ii(0x1010_e85b, 5); calld(0x1007_5fdc, -0x9_8884);          /* call 0x10075fdc */
            ii(0x1010_e860, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_e862, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1010_e865, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x1010_e867, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1010_e86a, 5); calld(0x100c_aafc, -0x4_3d73);          /* call 0x100caafc */
            ii(0x1010_e86f, 2); jmpd(0x1010_e84c, -0x25); goto l_0x1010_e84c; /* jmp 0x1010e84c */
        l_0x1010_e871:
            ii(0x1010_e871, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_e873, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1010_e876, 5); calld(0x1010_e501, -0x37a);             /* call 0x1010e501 */
            ii(0x1010_e87b, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1010_e87e, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_e882, 2); if(jnzd(0x1010_e888, 0x4)) goto l_0x1010_e888; /* jnz 0x1010e888 */
            ii(0x1010_e884, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1010_e888:
            ii(0x1010_e888, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1010_e88c, 6); if(jzd(0x1010_e806, -0x8c)) goto l_0x1010_e806; /* jz 0x1010e806 */
            ii(0x1010_e892, 5); calld(/* sys */ 0x1016_be34, 0x5_d59d); /* call 0x1016be34 */
            ii(0x1010_e897, 5); calld(0x100e_88bd, -0x2_5fdf);          /* call 0x100e88bd */
            ii(0x1010_e89c, 5); calld(/* sys */ 0x1016_bcc4, 0x5_d423); /* call 0x1016bcc4 */
            ii(0x1010_e8a1, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1010_e8a6, 5); calld(0x100f_f0ba, -0xf7f1);            /* call 0x100ff0ba */
            ii(0x1010_e8ab, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
        l_0x1010_e8b2:
            ii(0x1010_e8b2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_e8b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e8b7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_e8b8, 1); popd(edi);                              /* pop edi */
            ii(0x1010_e8b9, 1); popd(esi);                              /* pop esi */
            ii(0x1010_e8ba, 1); popd(edx);                              /* pop edx */
            ii(0x1010_e8bb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_e8bc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_e8bd, 1); retd();                                 /* ret */
        }
    }
}
