using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a0d1da96-99e6-486c-8b7f-cacee9e1e5c2")]
        public void /* sys */ Method_1017_d718()
        {
            ii(0x1017_d718, 1); pushd(edx);                             /* push edx */
            ii(0x1017_d719, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_d71b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1017_d71d, 3); cmp(edx, 0x30);                         /* cmp edx, 0x30 */
            ii(0x1017_d720, 2); if(jld(0x1017_d72c, 0xa)) goto l_0x1017_d72c; /* jl 0x1017d72c */
            ii(0x1017_d722, 3); cmp(edx, 0x39);                         /* cmp edx, 0x39 */
            ii(0x1017_d725, 2); if(jgd(0x1017_d72c, 0x5)) goto l_0x1017_d72c; /* jg 0x1017d72c */
            ii(0x1017_d727, 3); lea(eax, edx - 0x30);                   /* lea eax, [edx-0x30] */
            ii(0x1017_d72a, 1); popd(edx);                              /* pop edx */
            ii(0x1017_d72b, 1); retd(); return;                         /* ret */
        l_0x1017_d72c:
            ii(0x1017_d72c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_d731, 5); calld(Definitions.sys_toupper, 0x37b4); /* call 0x10180eea */
            ii(0x1017_d736, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_d738, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1017_d73e, 3); cmp(edx, 0x61);                         /* cmp edx, 0x61 */
            ii(0x1017_d741, 2); if(jld(0x1017_d74d, 0xa)) goto l_0x1017_d74d; /* jl 0x1017d74d */
            ii(0x1017_d743, 3); cmp(edx, 0x69);                         /* cmp edx, 0x69 */
            ii(0x1017_d746, 2); if(jgd(0x1017_d74d, 0x5)) goto l_0x1017_d74d; /* jg 0x1017d74d */
        l_0x1017_d748:
            ii(0x1017_d748, 3); lea(eax, edx - 0x57);                   /* lea eax, [edx-0x57] */
            ii(0x1017_d74b, 1); popd(edx);                              /* pop edx */
            ii(0x1017_d74c, 1); retd(); return;                         /* ret */
        l_0x1017_d74d:
            ii(0x1017_d74d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_d74f, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1017_d751, 3); cmp(edx, 0x6a);                         /* cmp edx, 0x6a */
            ii(0x1017_d754, 2); if(jld(0x1017_d75b, 0x5)) goto l_0x1017_d75b; /* jl 0x1017d75b */
            ii(0x1017_d756, 3); cmp(edx, 0x72);                         /* cmp edx, 0x72 */
            ii(0x1017_d759, 2); if(jled(0x1017_d748, -0x13)) goto l_0x1017_d748; /* jle 0x1017d748 */
        l_0x1017_d75b:
            ii(0x1017_d75b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_d760, 3); cmp(eax, 0x73);                         /* cmp eax, 0x73 */
            ii(0x1017_d763, 2); if(jld(0x1017_d76f, 0xa)) goto l_0x1017_d76f; /* jl 0x1017d76f */
            ii(0x1017_d765, 3); cmp(eax, 0x7a);                         /* cmp eax, 0x7a */
            ii(0x1017_d768, 2); if(jgd(0x1017_d76f, 0x5)) goto l_0x1017_d76f; /* jg 0x1017d76f */
            ii(0x1017_d76a, 3); sub(eax, 0x57);                         /* sub eax, 0x57 */
            ii(0x1017_d76d, 1); popd(edx);                              /* pop edx */
            ii(0x1017_d76e, 1); retd(); return;                         /* ret */
        l_0x1017_d76f:
            ii(0x1017_d76f, 5); mov(eax, 0x25);                         /* mov eax, 0x25 */
            ii(0x1017_d774, 1); popd(edx);                              /* pop edx */
            ii(0x1017_d775, 1); retd(); return;                         /* ret */
        }
    }
}
