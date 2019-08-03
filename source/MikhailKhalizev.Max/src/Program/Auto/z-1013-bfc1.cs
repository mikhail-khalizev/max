using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5c3fb09f-3615-45cb-b346-ba0a72a60e99")]
        public void Method_1013_bfc1()
        {
            ii(0x1013_bfc1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_bfc6, 5); calld(Definitions.sys_check_available_stack_size, 0x29d87); /* call 0x10165d52 */
            ii(0x1013_bfcb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_bfcc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_bfcd, 1); pushd(edx);                             /* push edx */
            ii(0x1013_bfce, 1); pushd(esi);                             /* push esi */
            ii(0x1013_bfcf, 1); pushd(edi);                             /* push edi */
            ii(0x1013_bfd0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_bfd1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_bfd3, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_bfd9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_bfdc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_bfdf, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_bfe2, 5); calld(0x1013_c724, 0x73d);              /* call 0x1013c724 */
            ii(0x1013_bfe7, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1013_bfea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_bfec, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_bfee, 5); calld(0x1013_c53c, 0x549);              /* call 0x1013c53c */
            ii(0x1013_bff3, 2); jmpd(0x1013_bffd, 0x8); goto l_0x1013_bffd; /* jmp 0x1013bffd */
        l_0x1013_bff5:
            ii(0x1013_bff5, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_bff8, 5); calld(0x1007_6bf8, -0xc5405);           /* call 0x10076bf8 */
        l_0x1013_bffd:
            ii(0x1013_bffd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_bfff, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_c002, 5); calld(0x1013_ad71, -0x1296);            /* call 0x1013ad71 */
            ii(0x1013_c007, 2); test(al, al);                           /* test al, al */
            ii(0x1013_c009, 2); if(jzd(0x1013_c01c, 0x11)) goto l_0x1013_c01c; /* jz 0x1013c01c */
            ii(0x1013_c00b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_c00d, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_c010, 5); calld(0x1013_c4c4, 0x4af);              /* call 0x1013c4c4 */
            ii(0x1013_c015, 5); calld(0x1013_c868, 0x84e);              /* call 0x1013c868 */
            ii(0x1013_c01a, 2); jmpd(0x1013_bff5, -0x27); goto l_0x1013_bff5; /* jmp 0x1013bff5 */
        l_0x1013_c01c:
            ii(0x1013_c01c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c01f, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_c022, 5); calld(0x1013_a6f4, -0x1933);            /* call 0x1013a6f4 */
            ii(0x1013_c027, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c02a, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1013_c02d, 2); if(jzd(0x1013_c039, 0xa)) goto l_0x1013_c039; /* jz 0x1013c039 */
            ii(0x1013_c02f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c032, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_c034, 5); calld(Definitions.sys_fclose, 0x36030); /* call 0x10172069 */
        l_0x1013_c039:
            ii(0x1013_c039, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c03c, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1013_c042, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_c044, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_c047, 5); calld(0x1013_c484, 0x438);              /* call 0x1013c484 */
            ii(0x1013_c04c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c04e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c04f, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c050, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c051, 1); popd(edx);                              /* pop edx */
            ii(0x1013_c052, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c053, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c054, 1); retd(); return;                         /* ret */
        }
    }
}