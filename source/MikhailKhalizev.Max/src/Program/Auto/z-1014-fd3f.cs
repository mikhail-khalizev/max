using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_fd3f-df0f4562")]
        public void Method_1014_fd3f()
        {
            ii(0x1014_fd3f, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1014_fd44, 5); calld(Definitions.sys_check_available_stack_size, 0x1_6009); /* call 0x10165d52 */
            ii(0x1014_fd49, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_fd4a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_fd4b, 1); pushd(edx);                             /* push edx */
            ii(0x1014_fd4c, 1); pushd(esi);                             /* push esi */
            ii(0x1014_fd4d, 1); pushd(edi);                             /* push edi */
            ii(0x1014_fd4e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_fd4f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_fd51, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_fd57, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_fd5a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fd5d, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_fd60, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_fd63, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_fd66, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x2); /* cmp byte [eax+0x101c81d5], 0x2 */
            ii(0x1014_fd6d, 2); if(jzd(0x1014_fd78, 0x9)) goto l_0x1014_fd78; /* jz 0x1014fd78 */
            ii(0x1014_fd6f, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_fd76, 2); jmpd(0x1014_fdc1, 0x49); goto l_0x1014_fdc1; /* jmp 0x1014fdc1 */
        l_0x1014_fd78:
            ii(0x1014_fd78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_fd7a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fd7d, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fd80, 5); calld(0x1013_ad11, -0x1_5074);          /* call 0x1013ad11 */
            ii(0x1014_fd85, 2); test(al, al);                           /* test al, al */
            ii(0x1014_fd87, 2); if(jzd(0x1014_fd95, 0xc)) goto l_0x1014_fd95; /* jz 0x1014fd95 */
            ii(0x1014_fd89, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fd8c, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1014_fd90, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_fd93, 2); jmpd(0x1014_fdc1, 0x2c); goto l_0x1014_fdc1; /* jmp 0x1014fdc1 */
        l_0x1014_fd95:
            ii(0x1014_fd95, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_fd98, 5); calld(0x1007_20b1, -0xd_dcec);          /* call 0x100720b1 */
            ii(0x1014_fd9d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_fda0, 5); calld(0x1007_20b1, -0xd_dcf4);          /* call 0x100720b1 */
            ii(0x1014_fda5, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1014_fda8, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1014_fdab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fdae, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fdb1, 5); calld(0x1007_68e0, -0xd_94d6);          /* call 0x100768e0 */
            ii(0x1014_fdb6, 5); calld(0x1014_3616, -0xc7a5);            /* call 0x10143616 */
            ii(0x1014_fdbb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_fdbe, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1014_fdc1:
            ii(0x1014_fdc1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fdc4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_fdc6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_fdc7, 1); popd(edi);                              /* pop edi */
            ii(0x1014_fdc8, 1); popd(esi);                              /* pop esi */
            ii(0x1014_fdc9, 1); popd(edx);                              /* pop edx */
            ii(0x1014_fdca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_fdcb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_fdcc, 1); retd();                                 /* ret */
        }
    }
}
