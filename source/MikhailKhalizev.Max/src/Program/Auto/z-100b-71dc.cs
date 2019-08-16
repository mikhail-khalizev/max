using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8eeabd10-62f6-47c1-8adb-c04200b91690")]
        public void Method_100b_71dc()
        {
            ii(0x100b_71dc, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100b_71e1, 5); calld(Definitions.sys_check_available_stack_size, 0xa_eb6c); /* call 0x10165d52 */
            ii(0x100b_71e6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_71e7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_71e8, 1); pushd(esi);                             /* push esi */
            ii(0x100b_71e9, 1); pushd(edi);                             /* push edi */
            ii(0x100b_71ea, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_71eb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_71ed, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_71f3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_71f6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_71f9, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100b_71fd, 5); calld(0x100b_7152, -0xb0);              /* call 0x100b7152 */
            ii(0x100b_7202, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_7204, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_7207, 5); calld(0x1007_64b8, -0x4_0d54);          /* call 0x100764b8 */
            ii(0x100b_720c, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_7213, 2); jmpd(0x100b_721d, 0x8); goto l_0x100b_721d; /* jmp 0x100b721d */
        l_0x100b_7215:
            ii(0x100b_7215, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_7218, 5); calld(0x1007_6bf8, -0x4_0625);          /* call 0x10076bf8 */
        l_0x100b_721d:
            ii(0x100b_721d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_721f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_7222, 5); calld(0x1013_ad71, 0x8_3b4a);           /* call 0x1013ad71 */
            ii(0x100b_7227, 2); test(al, al);                           /* test al, al */
            ii(0x100b_7229, 2); if(jzd(0x100b_726c, 0x41)) goto l_0x100b_726c; /* jz 0x100b726c */
            ii(0x100b_722b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_722e, 5); calld(0x1007_63a0, -0x4_0e93);          /* call 0x100763a0 */
            ii(0x100b_7233, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7235, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_7238, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100b_723c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_723e, 2); if(jnzd(0x100b_7252, 0x12)) goto l_0x100b_7252; /* jnz 0x100b7252 */
            ii(0x100b_7240, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_7243, 5); calld(0x1007_63a0, -0x4_0ea8);          /* call 0x100763a0 */
            ii(0x100b_7248, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100b_724c, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100b_7250, 2); if(jzd(0x100b_7254, 0x2)) goto l_0x100b_7254; /* jz 0x100b7254 */
        l_0x100b_7252:
            ii(0x100b_7252, 2); jmpd(0x100b_7262, 0xe); goto l_0x100b_7262; /* jmp 0x100b7262 */
        l_0x100b_7254:
            ii(0x100b_7254, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_7257, 5); calld(0x1007_63a0, -0x4_0ebc);          /* call 0x100763a0 */
            ii(0x100b_725c, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1e);    /* cmp byte [eax+0x3e], 0x1e */
            ii(0x100b_7260, 2); if(jnzd(0x100b_7264, 0x2)) goto l_0x100b_7264; /* jnz 0x100b7264 */
        l_0x100b_7262:
            ii(0x100b_7262, 2); jmpd(0x100b_726a, 0x6); goto l_0x100b_726a; /* jmp 0x100b726a */
        l_0x100b_7264:
            ii(0x100b_7264, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_7267, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_726a:
            ii(0x100b_726a, 2); jmpd(0x100b_7215, -0x57); goto l_0x100b_7215; /* jmp 0x100b7215 */
        l_0x100b_726c:
            ii(0x100b_726c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_726f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_7272, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7274, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_7277, 5); calld(0x1007_5f6c, -0x4_1310);          /* call 0x10075f6c */
            ii(0x100b_727c, 2); jmpd(0x100b_7288, 0xa); goto l_0x100b_7288; /* jmp 0x100b7288 */
        //    ii(0x100b_727e, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100b_7280, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x100b_7283, 5); calld(0x1007_5f6c, -0x4_131c);          /* call 0x10075f6c */
        l_0x100b_7288:
            ii(0x100b_7288, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_728b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_728d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_728e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_728f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7290, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7291, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7292, 1); retd(); return;                         /* ret */
        }
    }
}