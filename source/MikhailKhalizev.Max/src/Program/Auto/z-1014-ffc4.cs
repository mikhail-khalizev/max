using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_ffc4-b3115257")]
        public void Method_1014_ffc4()
        {
            ii(0x1014_ffc4, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1014_ffc9, 5); call(Definitions.sys_check_available_stack_size, 0x1_5d84); /* call 0x10165d52 */
            ii(0x1014_ffce, 1); push(ebx);                              /* push ebx */
            ii(0x1014_ffcf, 1); push(ecx);                              /* push ecx */
            ii(0x1014_ffd0, 1); push(edx);                              /* push edx */
            ii(0x1014_ffd1, 1); push(esi);                              /* push esi */
            ii(0x1014_ffd2, 1); push(edi);                              /* push edi */
            ii(0x1014_ffd3, 1); push(ebp);                              /* push ebp */
            ii(0x1014_ffd4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_ffd6, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_ffdc, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_ffdf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_ffe2, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1014_ffe5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_ffe8, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_ffeb, 7); cmp(memb[ds, eax + 0x101c_81d5], 0x3);  /* cmp byte [eax+0x101c81d5], 0x3 */
            ii(0x1014_fff2, 2); if(jz(0x1014_fffd, 0x9)) goto l_0x1014_fffd; /* jz 0x1014fffd */
            ii(0x1014_fff4, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_fffb, 2); jmp(0x1015_0055, 0x58); goto l_0x1015_0055; /* jmp 0x10150055 */
        l_0x1014_fffd:
            ii(0x1014_fffd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ffff, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0002, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_0005, 5); call(0x1013_ad11, -0x1_52f9);           /* call 0x1013ad11 */
            ii(0x1015_000a, 2); test(al, al);                           /* test al, al */
            ii(0x1015_000c, 2); if(jz(0x1015_0026, 0x18)) goto l_0x1015_0026; /* jz 0x10150026 */
            ii(0x1015_000e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_0011, 5); call(0x1007_623c, -0xd_9dda);           /* call 0x1007623c */
            ii(0x1015_0016, 4); mov(ax, memw[ds, eax + 0x19]);          /* mov ax, [eax+0x19] */
            ii(0x1015_001a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_001d, 4); sub(ax, memw[ds, edx + 0x52]);          /* sub ax, [edx+0x52] */
            ii(0x1015_0021, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_0024, 2); jmp(0x1015_0055, 0x2f); goto l_0x1015_0055; /* jmp 0x10150055 */
        l_0x1015_0026:
            ii(0x1015_0026, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1015_0029, 5); call(0x1007_20b1, -0xd_df7d);           /* call 0x100720b1 */
            ii(0x1015_002e, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1015_0031, 5); call(0x1007_20b1, -0xd_df85);           /* call 0x100720b1 */
            ii(0x1015_0036, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x1015_0039, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1015_003c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_003f, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_0042, 5); call(0x1007_68e0, -0xd_9767);           /* call 0x100768e0 */
            ii(0x1015_0047, 5); call(0x1014_3616, -0xca36);             /* call 0x10143616 */
            ii(0x1015_004c, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1015_004f, 3); sub(eax, memd[ss, ebp - 0x14]);         /* sub eax, [ebp-0x14] */
            ii(0x1015_0052, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x1015_0055:
            ii(0x1015_0055, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_0058, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_005a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_005b, 1); pop(edi);                               /* pop edi */
            ii(0x1015_005c, 1); pop(esi);                               /* pop esi */
            ii(0x1015_005d, 1); pop(edx);                               /* pop edx */
            ii(0x1015_005e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_005f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_0060, 1); ret();                                  /* ret */
        }
    }
}
