using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_fbd6-cd8323e2")]
        public void Method_1014_fbd6()
        {
            ii(0x1014_fbd6, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1014_fbdb, 5); call(Definitions.sys_check_available_stack_size, 0x1_6172); /* call 0x10165d52 */
            ii(0x1014_fbe0, 1); push(ebx);                              /* push ebx */
            ii(0x1014_fbe1, 1); push(ecx);                              /* push ecx */
            ii(0x1014_fbe2, 1); push(edx);                              /* push edx */
            ii(0x1014_fbe3, 1); push(esi);                              /* push esi */
            ii(0x1014_fbe4, 1); push(edi);                              /* push edi */
            ii(0x1014_fbe5, 1); push(ebp);                              /* push ebp */
            ii(0x1014_fbe6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_fbe8, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_fbee, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_fbf1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fbf4, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1014_fbf7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_fbfa, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_fbfd, 7); cmp(memb[ds, eax + 0x101c_81d5], 0x1);  /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1014_fc04, 2); if(jz(0x1014_fc0f, 0x9)) goto l_0x1014_fc0f; /* jz 0x1014fc0f */
            ii(0x1014_fc06, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_fc0d, 2); jmp(0x1014_fc67, 0x58); goto l_0x1014_fc67; /* jmp 0x1014fc67 */
        l_0x1014_fc0f:
            ii(0x1014_fc0f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_fc11, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fc14, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fc17, 5); call(0x1013_ad11, -0x1_4f0b);           /* call 0x1013ad11 */
            ii(0x1014_fc1c, 2); test(al, al);                           /* test al, al */
            ii(0x1014_fc1e, 2); if(jz(0x1014_fc38, 0x18)) goto l_0x1014_fc38; /* jz 0x1014fc38 */
            ii(0x1014_fc20, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fc23, 5); call(0x1007_623c, -0xd_99ec);           /* call 0x1007623c */
            ii(0x1014_fc28, 4); mov(ax, memw[ds, eax + 0x19]);          /* mov ax, [eax+0x19] */
            ii(0x1014_fc2c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_fc2f, 4); sub(ax, memw[ds, edx + 0x52]);          /* sub ax, [edx+0x52] */
            ii(0x1014_fc33, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_fc36, 2); jmp(0x1014_fc67, 0x2f); goto l_0x1014_fc67; /* jmp 0x1014fc67 */
        l_0x1014_fc38:
            ii(0x1014_fc38, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1014_fc3b, 5); call(0x1007_20b1, -0xd_db8f);           /* call 0x100720b1 */
            ii(0x1014_fc40, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1014_fc43, 5); call(0x1007_20b1, -0xd_db97);           /* call 0x100720b1 */
            ii(0x1014_fc48, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1014_fc4b, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x1014_fc4e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fc51, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fc54, 5); call(0x1007_68e0, -0xd_9379);           /* call 0x100768e0 */
            ii(0x1014_fc59, 5); call(0x1014_3616, -0xc648);             /* call 0x10143616 */
            ii(0x1014_fc5e, 3); mov(eax, memd[ss, ebp - 0x1e]);         /* mov eax, [ebp-0x1e] */
            ii(0x1014_fc61, 3); sub(eax, memd[ss, ebp - 0x12]);         /* sub eax, [ebp-0x12] */
            ii(0x1014_fc64, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x1014_fc67:
            ii(0x1014_fc67, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fc6a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_fc6c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_fc6d, 1); pop(edi);                               /* pop edi */
            ii(0x1014_fc6e, 1); pop(esi);                               /* pop esi */
            ii(0x1014_fc6f, 1); pop(edx);                               /* pop edx */
            ii(0x1014_fc70, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_fc71, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_fc72, 1); ret();                                  /* ret */
        }
    }
}
