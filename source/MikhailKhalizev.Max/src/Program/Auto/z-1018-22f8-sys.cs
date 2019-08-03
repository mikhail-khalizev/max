using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0ee85232-2d8a-454a-a96b-c90bb8a99c52")]
        public void /* sys */ Method_1018_22f8()
        {
            ii(0x1018_22f8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_22f9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_22fa, 1); pushd(edx);                             /* push edx */
            ii(0x1018_22fb, 1); pushd(esi);                             /* push esi */
            ii(0x1018_22fc, 1); pushd(edi);                             /* push edi */
            ii(0x1018_22fd, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_22ff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_2301, 2); if(jzd(0x1018_236e, 0x6b)) goto l_0x1018_236e; /* jz 0x1018236e */
            ii(0x1018_2303, 3); lea(esi, eax + 0xc);                    /* lea esi, [eax+0xc] */
            ii(0x1018_2306, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_2308, 5); calld(Definitions.sys_malloc, -0x1732f); /* call 0x1016afde */
            ii(0x1018_230d, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1018_230f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_2311, 2); if(jzd(0x1018_236e, 0x5b)) goto l_0x1018_236e; /* jz 0x1018236e */
            ii(0x1018_2313, 5); pushd(0xcc);                            /* push 0xcc */
            ii(0x1018_2318, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1018_231d, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1018_231f, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1018_2321, 5); calld(/* sys */ 0x1016_ad78, -0x175ae); /* call 0x1016ad78 */
            ii(0x1018_2326, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1018_2328, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1018_232a, 5); calld(/* sys */ 0x1018_25c0, 0x291);    /* call 0x101825c0 */
            ii(0x1018_232f, 6); mov(edx, memd_a32[ds, 0x101b_e824]);    /* mov edx, [0x101be824] */
            ii(0x1018_2335, 6); mov(ebx, memd_a32[ds, 0x101b_e828]);    /* mov ebx, [0x101be828] */
            ii(0x1018_233b, 1); inc(edx);                               /* inc edx */
            ii(0x1018_233c, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1018_233e, 6); mov(memd_a32[ds, 0x101b_e824], edx);    /* mov [0x101be824], edx */
            ii(0x1018_2344, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1018_2346, 2); if(jled(0x1018_234e, 0x6)) goto l_0x1018_234e; /* jle 0x1018234e */
            ii(0x1018_2348, 6); mov(memd_a32[ds, 0x101b_e828], edx);    /* mov [0x101be828], edx */
        l_0x1018_234e:
            ii(0x1018_234e, 6); mov(ecx, memd_a32[ds, 0x101b_e82c]);    /* mov ecx, [0x101be82c] */
            ii(0x1018_2354, 2); add(ecx, esi);                          /* add ecx, esi */
            ii(0x1018_2356, 6); mov(esi, memd_a32[ds, 0x101b_e830]);    /* mov esi, [0x101be830] */
            ii(0x1018_235c, 6); mov(memd_a32[ds, 0x101b_e82c], ecx);    /* mov [0x101be82c], ecx */
            ii(0x1018_2362, 2); cmp(ecx, esi);                          /* cmp ecx, esi */
            ii(0x1018_2364, 2); if(jbed(0x1018_236c, 0x6)) goto l_0x1018_236c; /* jbe 0x1018236c */
            ii(0x1018_2366, 6); mov(memd_a32[ds, 0x101b_e830], ecx);    /* mov [0x101be830], ecx */
        l_0x1018_236c:
            ii(0x1018_236c, 2); mov(eax, edi);                          /* mov eax, edi */
        l_0x1018_236e:
            ii(0x1018_236e, 1); popd(edi);                              /* pop edi */
            ii(0x1018_236f, 1); popd(esi);                              /* pop esi */
            ii(0x1018_2370, 1); popd(edx);                              /* pop edx */
            ii(0x1018_2371, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_2372, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_2373, 1); retd(); return;                         /* ret */
        }
    }
}