using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_de31-10e60813")]
        public void Method_1015_de31()
        {
            ii(0x1015_de31, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_de36, 5); calld(Definitions.sys_check_available_stack_size, 0x7f17); /* call 0x10165d52 */
            ii(0x1015_de3b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_de3c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_de3d, 1); pushd(edx);                             /* push edx */
            ii(0x1015_de3e, 1); pushd(esi);                             /* push esi */
            ii(0x1015_de3f, 1); pushd(edi);                             /* push edi */
            ii(0x1015_de40, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_de41, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_de43, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_de49, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_de4c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_de4f, 5); calld(0x1007_6338, -0xe_7b1c);          /* call 0x10076338 */
            ii(0x1015_de54, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_de56, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_de59, 5); calld(0x1007_64b8, -0xe_79a6);          /* call 0x100764b8 */
        l_0x1015_de5e:
            ii(0x1015_de5e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_de60, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_de63, 5); calld(0x1013_ad71, -0x2_30f7);          /* call 0x1013ad71 */
            ii(0x1015_de68, 2); test(al, al);                           /* test al, al */
            ii(0x1015_de6a, 2); if(jzd(0x1015_dea6, 0x3a)) goto l_0x1015_dea6; /* jz 0x1015dea6 */
            ii(0x1015_de6c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_de6f, 5); calld(0x1007_63a0, -0xe_7ad4);          /* call 0x100763a0 */
            ii(0x1015_de74, 4); cmp(memb_a32[ds, eax + 0x59], 0);       /* cmp byte [eax+0x59], 0x0 */
            ii(0x1015_de78, 2); if(jzd(0x1015_de8e, 0x14)) goto l_0x1015_de8e; /* jz 0x1015de8e */
            ii(0x1015_de7a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_de7d, 5); calld(0x1007_63a0, -0xe_7ae2);          /* call 0x100763a0 */
            ii(0x1015_de82, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1015_de85, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_de8a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_de8c, 2); if(jgd(0x1015_de90, 0x2)) goto l_0x1015_de90; /* jg 0x1015de90 */
        l_0x1015_de8e:
            ii(0x1015_de8e, 2); jmpd(0x1015_de9c, 0xc); goto l_0x1015_de9c; /* jmp 0x1015de9c */
        l_0x1015_de90:
            ii(0x1015_de90, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_de93, 5); calld(0x1007_63a0, -0xe_7af8);          /* call 0x100763a0 */
            ii(0x1015_de98, 4); mov(memb_a32[ds, eax + 0x59], 0);       /* mov byte [eax+0x59], 0x0 */
        l_0x1015_de9c:
            ii(0x1015_de9c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_de9f, 5); calld(0x1007_6bf8, -0xe_72ac);          /* call 0x10076bf8 */
            ii(0x1015_dea4, 2); jmpd(0x1015_de5e, -0x48); goto l_0x1015_de5e; /* jmp 0x1015de5e */
        l_0x1015_dea6:
            ii(0x1015_dea6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_dea8, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_deab, 5); calld(0x1007_5f6c, -0xe_7f44);          /* call 0x10075f6c */
            ii(0x1015_deb0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_deb2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_deb3, 1); popd(edi);                              /* pop edi */
            ii(0x1015_deb4, 1); popd(esi);                              /* pop esi */
            ii(0x1015_deb5, 1); popd(edx);                              /* pop edx */
            ii(0x1015_deb6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_deb7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_deb8, 1); retd();                                 /* ret */
        }
    }
}
