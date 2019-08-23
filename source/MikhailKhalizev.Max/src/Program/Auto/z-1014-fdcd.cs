using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_fdcd-fb822ae6")]
        public void Method_1014_fdcd()
        {
            ii(0x1014_fdcd, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1014_fdd2, 5); calld(Definitions.sys_check_available_stack_size, 0x1_5f7b); /* call 0x10165d52 */
            ii(0x1014_fdd7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_fdd8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_fdd9, 1); pushd(edx);                             /* push edx */
            ii(0x1014_fdda, 1); pushd(esi);                             /* push esi */
            ii(0x1014_fddb, 1); pushd(edi);                             /* push edi */
            ii(0x1014_fddc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_fddd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_fddf, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_fde5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_fde8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fdeb, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_fdee, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_fdf1, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_fdf4, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x2); /* cmp byte [eax+0x101c81d5], 0x2 */
            ii(0x1014_fdfb, 2); if(jzd(0x1014_fe06, 0x9)) goto l_0x1014_fe06; /* jz 0x1014fe06 */
            ii(0x1014_fdfd, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_fe04, 2); jmpd(0x1014_fe5e, 0x58); goto l_0x1014_fe5e; /* jmp 0x1014fe5e */
        l_0x1014_fe06:
            ii(0x1014_fe06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_fe08, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fe0b, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fe0e, 5); calld(0x1013_ad11, -0x1_5102);          /* call 0x1013ad11 */
            ii(0x1014_fe13, 2); test(al, al);                           /* test al, al */
            ii(0x1014_fe15, 2); if(jzd(0x1014_fe2f, 0x18)) goto l_0x1014_fe2f; /* jz 0x1014fe2f */
            ii(0x1014_fe17, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fe1a, 5); calld(0x1007_623c, -0xd_9be3);          /* call 0x1007623c */
            ii(0x1014_fe1f, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1014_fe23, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_fe26, 4); sub(ax, memw_a32[ds, edx + 0x52]);      /* sub ax, [edx+0x52] */
            ii(0x1014_fe2a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_fe2d, 2); jmpd(0x1014_fe5e, 0x2f); goto l_0x1014_fe5e; /* jmp 0x1014fe5e */
        l_0x1014_fe2f:
            ii(0x1014_fe2f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_fe32, 5); calld(0x1007_20b1, -0xd_dd86);          /* call 0x100720b1 */
            ii(0x1014_fe37, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_fe3a, 5); calld(0x1007_20b1, -0xd_dd8e);          /* call 0x100720b1 */
            ii(0x1014_fe3f, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1014_fe42, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1014_fe45, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fe48, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fe4b, 5); calld(0x1007_68e0, -0xd_9570);          /* call 0x100768e0 */
            ii(0x1014_fe50, 5); calld(0x1014_3616, -0xc83f);            /* call 0x10143616 */
            ii(0x1014_fe55, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_fe58, 3); sub(eax, memd_a32[ss, ebp - 0x10]);     /* sub eax, [ebp-0x10] */
            ii(0x1014_fe5b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1014_fe5e:
            ii(0x1014_fe5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fe61, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_fe63, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_fe64, 1); popd(edi);                              /* pop edi */
            ii(0x1014_fe65, 1); popd(esi);                              /* pop esi */
            ii(0x1014_fe66, 1); popd(edx);                              /* pop edx */
            ii(0x1014_fe67, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_fe68, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_fe69, 1); retd();                                 /* ret */
        }
    }
}
