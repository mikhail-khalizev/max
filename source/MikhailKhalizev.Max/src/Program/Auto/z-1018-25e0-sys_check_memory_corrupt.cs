using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_25e0-5ab4444d")]
        public void /* sys */ sys_check_memory_corrupt()
        {
            ii(0x1018_25e0, 1); push(ebx);                              /* push ebx */
            ii(0x1018_25e1, 1); push(ecx);                              /* push ecx */
            ii(0x1018_25e2, 1); push(edx);                              /* push edx */
            ii(0x1018_25e3, 1); push(edi);                              /* push edi */
            ii(0x1018_25e4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_25e6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_25e8, 3); mov(ecx, memd[ds, eax + 0x4]);          /* mov ecx, [eax+0x4] */
            ii(0x1018_25eb, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1018_25ee, 6); cmp(ecx, 0xfeed_face);                  /* cmp ecx, 0xfeedface */
            ii(0x1018_25f4, 2); if(jz(0x1018_2603, 0xd)) goto l_0x1018_2603; /* jz 0x10182603 */
            ii(0x1018_25f6, 5); push(StringDefinitions.MemoryHeaderStomped); /* push 0x101b3384 */
            ii(0x1018_25fb, 5); call(/* sys */ 0x1018_28a8, 0x2a8);     /* call 0x101828a8 */
            ii(0x1018_2600, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1018_2603:
            ii(0x1018_2603, 2); add(edx, memd[ds, ebx]);                /* add edx, [ebx] */
            ii(0x1018_2605, 3); mov(edi, memd[ds, edx - 0x4]);          /* mov edi, [edx-0x4] */
            ii(0x1018_2608, 3); sub(edx, 0x4);                          /* sub edx, 0x4 */
            ii(0x1018_260b, 6); cmp(edi, 0xbeef_cafe);                  /* cmp edi, 0xbeefcafe */
            ii(0x1018_2611, 2); if(jz(0x1018_2620, 0xd)) goto l_0x1018_2620; /* jz 0x10182620 */
            ii(0x1018_2613, 5); push(StringDefinitions.MemoryFooterStomped); /* push 0x101b339c */
            ii(0x1018_2618, 5); call(/* sys */ 0x1018_28a8, 0x28b);     /* call 0x101828a8 */
            ii(0x1018_261d, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1018_2620:
            ii(0x1018_2620, 1); pop(edi);                               /* pop edi */
            ii(0x1018_2621, 1); pop(edx);                               /* pop edx */
            ii(0x1018_2622, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_2623, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_2624, 1); ret();                                  /* ret */
        }
    }
}
