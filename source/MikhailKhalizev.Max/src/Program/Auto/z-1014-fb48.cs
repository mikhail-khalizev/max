using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_fb48-830a3cd3")]
        public void Method_1014_fb48()
        {
            ii(0x1014_fb48, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1014_fb4d, 5); calld(Definitions.sys_check_available_stack_size, 0x1_6200); /* call 0x10165d52 */
            ii(0x1014_fb52, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_fb53, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_fb54, 1); pushd(edx);                             /* push edx */
            ii(0x1014_fb55, 1); pushd(esi);                             /* push esi */
            ii(0x1014_fb56, 1); pushd(edi);                             /* push edi */
            ii(0x1014_fb57, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_fb58, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_fb5a, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_fb60, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_fb63, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fb66, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_fb69, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_fb6c, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_fb6f, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1014_fb76, 2); if(jzd(0x1014_fb81, 0x9)) goto l_0x1014_fb81; /* jz 0x1014fb81 */
            ii(0x1014_fb78, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_fb7f, 2); jmpd(0x1014_fbca, 0x49); goto l_0x1014_fbca; /* jmp 0x1014fbca */
        l_0x1014_fb81:
            ii(0x1014_fb81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_fb83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fb86, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fb89, 5); calld(0x1013_ad11, -0x1_4e7d);          /* call 0x1013ad11 */
            ii(0x1014_fb8e, 2); test(al, al);                           /* test al, al */
            ii(0x1014_fb90, 2); if(jzd(0x1014_fb9e, 0xc)) goto l_0x1014_fb9e; /* jz 0x1014fb9e */
            ii(0x1014_fb92, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fb95, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1014_fb99, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_fb9c, 2); jmpd(0x1014_fbca, 0x2c); goto l_0x1014_fbca; /* jmp 0x1014fbca */
        l_0x1014_fb9e:
            ii(0x1014_fb9e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_fba1, 5); calld(0x1007_20b1, -0xd_daf5);          /* call 0x100720b1 */
            ii(0x1014_fba6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_fba9, 5); calld(0x1007_20b1, -0xd_dafd);          /* call 0x100720b1 */
            ii(0x1014_fbae, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1014_fbb1, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1014_fbb4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fbb7, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fbba, 5); calld(0x1007_68e0, -0xd_92df);          /* call 0x100768e0 */
            ii(0x1014_fbbf, 5); calld(0x1014_3616, -0xc5ae);            /* call 0x10143616 */
            ii(0x1014_fbc4, 3); mov(eax, memd_a32[ss, ebp - 0x12]);     /* mov eax, [ebp-0x12] */
            ii(0x1014_fbc7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1014_fbca:
            ii(0x1014_fbca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fbcd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_fbcf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_fbd0, 1); popd(edi);                              /* pop edi */
            ii(0x1014_fbd1, 1); popd(esi);                              /* pop esi */
            ii(0x1014_fbd2, 1); popd(edx);                              /* pop edx */
            ii(0x1014_fbd3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_fbd4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_fbd5, 1); retd();                                 /* ret */
        }
    }
}
