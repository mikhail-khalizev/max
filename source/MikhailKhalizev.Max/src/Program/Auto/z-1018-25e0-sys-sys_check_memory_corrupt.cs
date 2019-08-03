using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4ad078fe-e4e6-4c2b-bc83-47292084adf4")]
        public void /* sys */ sys_check_memory_corrupt()
        {
            ii(0x1018_25e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_25e1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_25e2, 1); pushd(edx);                             /* push edx */
            ii(0x1018_25e3, 1); pushd(edi);                             /* push edi */
            ii(0x1018_25e4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_25e6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_25e8, 3); mov(ecx, memd_a32[ds, eax + 0x4]);      /* mov ecx, [eax+0x4] */
            ii(0x1018_25eb, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1018_25ee, 6); cmp(ecx, 0xfeed_face);                  /* cmp ecx, 0xfeedface */
            ii(0x1018_25f4, 2); if(jzd(0x1018_2603, 0xd)) goto l_0x1018_2603; /* jz 0x10182603 */
            ii(0x1018_25f6, 5); pushd(0x101b_3384);                     /* push 0x101b3384 */ /* "Memory header stomped.\n" */
            ii(0x1018_25fb, 5); calld(/* sys */ 0x1018_28a8, 0x2a8);    /* call 0x101828a8 */
            ii(0x1018_2600, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1018_2603:
            ii(0x1018_2603, 2); add(edx, memd_a32[ds, ebx]);            /* add edx, [ebx] */
            ii(0x1018_2605, 3); mov(edi, memd_a32[ds, edx - 0x4]);      /* mov edi, [edx-0x4] */
            ii(0x1018_2608, 3); sub(edx, 0x4);                          /* sub edx, 0x4 */
            ii(0x1018_260b, 6); cmp(edi, 0xbeef_cafe);                  /* cmp edi, 0xbeefcafe */
            ii(0x1018_2611, 2); if(jzd(0x1018_2620, 0xd)) goto l_0x1018_2620; /* jz 0x10182620 */
            ii(0x1018_2613, 5); pushd(0x101b_339c);                     /* push 0x101b339c */ /* "Memory footer stomped.\n" */
            ii(0x1018_2618, 5); calld(/* sys */ 0x1018_28a8, 0x28b);    /* call 0x101828a8 */
            ii(0x1018_261d, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1018_2620:
            ii(0x1018_2620, 1); popd(edi);                              /* pop edi */
            ii(0x1018_2621, 1); popd(edx);                              /* pop edx */
            ii(0x1018_2622, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_2623, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_2624, 1); retd(); return;                         /* ret */
        }
    }
}
