using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_11fd-cbdb1922")]
        public void Method_1013_11fd()
        {
            ii(0x1013_11fd, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_1202, 5); call(Definitions.sys_check_available_stack_size, 0x3_4b4b); /* call 0x10165d52 */
            ii(0x1013_1207, 1); push(ebx);                              /* push ebx */
            ii(0x1013_1208, 1); push(ecx);                              /* push ecx */
            ii(0x1013_1209, 1); push(esi);                              /* push esi */
            ii(0x1013_120a, 1); push(edi);                              /* push edi */
            ii(0x1013_120b, 1); push(ebp);                              /* push ebp */
            ii(0x1013_120c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_120e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_1214, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1217, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_121a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_121d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_1220, 7); mov(memb[ds, 0x101c_61b1], 0);          /* mov byte [0x101c61b1], 0x0 */
            ii(0x1013_1227, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_122a, 5); call(0x1012_f003, -0x222c);             /* call 0x1012f003 */
            ii(0x1013_122f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_1232, 4); cmp(memb[ds, eax + 0x17], 0);           /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_1236, 2); if(jz(0x1013_1241, 0x9)) goto l_0x1013_1241; /* jz 0x10131241 */
            ii(0x1013_1238, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_123b, 4); cmp(memb[ds, eax + 0x17], 0x1);         /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_123f, 2); if(jnz(0x1013_124e, 0xd)) goto l_0x1013_124e; /* jnz 0x1013124e */
        l_0x1013_1241:
            ii(0x1013_1241, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_1246, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_1249, 5); call(0x1013_0c16, -0x638);              /* call 0x10130c16 */
        l_0x1013_124e:
            ii(0x1013_124e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1250, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_1251, 1); pop(edi);                               /* pop edi */
            ii(0x1013_1252, 1); pop(esi);                               /* pop esi */
            ii(0x1013_1253, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_1254, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_1255, 1); ret();                                  /* ret */
        }
    }
}
