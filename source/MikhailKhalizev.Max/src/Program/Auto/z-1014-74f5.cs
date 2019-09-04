using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_74f5-2db422bf")]
        public void Method_1014_74f5()
        {
            ii(0x1014_74f5, 5); push(0x34);                             /* push 0x34 */
            ii(0x1014_74fa, 5); call(Definitions.sys_check_available_stack_size, 0x1_e853); /* call 0x10165d52 */
            ii(0x1014_74ff, 1); push(ecx);                              /* push ecx */
            ii(0x1014_7500, 1); push(esi);                              /* push esi */
            ii(0x1014_7501, 1); push(edi);                              /* push edi */
            ii(0x1014_7502, 1); push(ebp);                              /* push ebp */
            ii(0x1014_7503, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7505, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_750b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1014_750e, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1014_7511, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1014_7514, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_7517, 5); call(0x1014_7395, -0x187);              /* call 0x10147395 */
            ii(0x1014_751c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_751f, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1014_7521, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_7524, 5); call(/* sys */ 0x1018_0f4d, 0x3_9a24);  /* call 0x10180f4d */
            ii(0x1014_7529, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1014_752c, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1014_752e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_7531, 1); push(eax);                              /* push eax */
            ii(0x1014_7532, 5); mov(eax, StringDefinitions.I16);        /* mov eax, 0x101ad129 */
            ii(0x1014_7537, 1); push(eax);                              /* push eax */
            ii(0x1014_7538, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1014_753d, 1); push(eax);                              /* push eax */
            ii(0x1014_753e, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1014_7541, 5); call(Definitions.my_string_ctor, -0x5a5e); /* call 0x10141ae8 */
            ii(0x1014_7546, 1); push(eax);                              /* push eax */
            ii(0x1014_7547, 5); call(0x1014_2037, -0x5515);             /* call 0x10142037 */
            ii(0x1014_754c, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1014_754f, 5); call(Definitions.my_strobj_c_str_v2, -0xb_dd8c); /* call 0x100897c8 */
            ii(0x1014_7554, 5); call(/* sys */ 0x1018_0f4d, 0x3_99f4);  /* call 0x10180f4d */
            ii(0x1014_7559, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_755b, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x1014_755e, 5); call(Definitions.my_string_dtor, -0x5a39); /* call 0x10141b2a */
            ii(0x1014_7563, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7565, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_7566, 1); pop(edi);                               /* pop edi */
            ii(0x1014_7567, 1); pop(esi);                               /* pop esi */
            ii(0x1014_7568, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_7569, 1); ret();                                  /* ret */
        }
    }
}
